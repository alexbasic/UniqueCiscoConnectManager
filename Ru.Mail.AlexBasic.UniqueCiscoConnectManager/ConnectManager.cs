using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;

namespace Ru.Mail.AlexBasic.UniqueCiscoConnectManager
{
    public class ConnectManager
    {
        private readonly IAsyncConsoleRunner _runner;
        private readonly Ping _ping;
        private readonly string _clientPath;
        private readonly string _connectCommand;
        private readonly string _disconnectCommand;
        private readonly string _address;
        private readonly int _delay;
        private readonly int _verifyInterval;

        private bool _connected;

        public bool Connected 
        {
            get { return _connected; }
        }

        public ConnectManager(string clientPath, string address, int delay, int verifyInterval, string profileName, ConsoleRunnerDataReceived outputCallback)
        {
            _runner = new AsyncConsoleRunner();
            _runner.OnConsoleRunnerDataReceived += (s ,p) => outputCallback(this, p);
            _runner.OnConsoleRunnerErrorDataReceived += (s, p) => outputCallback(this, p);

            _ping = new Ping();

            _address = address;
            _clientPath = clientPath;
            _connectCommand = $" connect \"{profileName}\"";
            _disconnectCommand = $" disconnect";

            _delay = delay;
            _verifyInterval = verifyInterval;
            _connected = false;
        }

        public async Task<bool> Reconnect()
        {
            var exitCode = await Disconnect();
            await Task.Delay(_delay);

            exitCode = exitCode && await Connect();
            await Task.Delay(_delay);

            return exitCode;
        }

        public async Task<bool> Connect()
        {
            var exitCode = await _runner.ExecuteCommand(_clientPath, _connectCommand, CancellationToken.None);
            var exitCodeCorrect = exitCode == 0 || exitCode == 200 || exitCode == 1;
            _connected = exitCodeCorrect;
            return exitCodeCorrect;
        }

        public async Task<bool> Disconnect()
        {
            var exitCode = await _runner.ExecuteCommand(_clientPath, _disconnectCommand, CancellationToken.None);
            var exitCodeCorrect = exitCode == 0 || exitCode == 15 || exitCode == 1;
            if (exitCodeCorrect) _connected = false;
            return exitCodeCorrect;
        }

        public async Task Start(CancellationToken token, ConsoleRunnerDataReceived outputCallback)
        {
            while (!token.IsCancellationRequested)
            {
                outputCallback(this, "ping");

                if (!await Ping())
                {
                    _connected = false;
                    outputCallback(this, "start reconnecting");
                    var reconnectingResult = await Reconnect();
                    if (reconnectingResult) outputCallback(this, "reconnected");
                    else outputCallback(this, "disconnected");
                }
                else 
                {
                    _connected = true;
                }
                if (token.IsCancellationRequested) break;
                outputCallback(this, "wait");
                try
                {
                    await Task.Delay(_verifyInterval, token);
                }
                catch (TaskCanceledException ex) 
                {
                }
            }
            _connected = false;
            outputCallback(this, "disconnected");
        }

        public async Task<bool> Ping()
        {
            try
            {
                var pingReply = await _ping.SendPingAsync(_address);
                return pingReply.Status == IPStatus.Success;
            }
            catch
            {
                return await Task.FromResult(false);
            }
        }
    }
}
