using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Ru.Mail.AlexBasic.UniqueCiscoConnectManager
{
    public delegate void ConsoleRunnerDataReceived(object sender, string e);
    public delegate void ConsoleRunnerErrorDataReceived(object sender, string e);

    public class AsyncConsoleRunner : IAsyncConsoleRunner
    {
        public event ConsoleRunnerDataReceived OnConsoleRunnerDataReceived;
        public event ConsoleRunnerDataReceived OnConsoleRunnerErrorDataReceived;
        public event EventHandler OnExited;

        public AsyncConsoleRunner()
        {
        }

        public async Task<int> ExecuteCommand(string command, CancellationToken token)
        {
            var processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            int exitCode;

            using (var process = new Process())
            {
                process.StartInfo = processInfo;

                process.OutputDataReceived += (object sender, DataReceivedEventArgs e) =>
                    OnConsoleRunnerDataReceived?.Invoke(sender, e.Data);

                process.ErrorDataReceived += (object sender, DataReceivedEventArgs e) =>
                    OnConsoleRunnerErrorDataReceived?.Invoke(sender, e.Data);

                process.Exited += (object sender, EventArgs e) =>
                {
                    OnExited?.Invoke(sender, e);
                };

                try
                {
                    var processStarted = process.Start();

                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();

                    await Task.Run(() => process.WaitForExit(), token);

                    process.CancelOutputRead();
                    process.CancelErrorRead();
                }
                catch (OperationCanceledException ex)
                {
                    process.CancelOutputRead();
                    process.CancelErrorRead();
                    process.Kill();
                }
                finally
                {
                    exitCode = process.ExitCode;
                    process.Close();
                }
            }

            return exitCode;
        }
    }

    public interface IAsyncConsoleRunner
    {
        event ConsoleRunnerDataReceived OnConsoleRunnerDataReceived;
        event ConsoleRunnerDataReceived OnConsoleRunnerErrorDataReceived;
        event EventHandler OnExited;

        Task<int> ExecuteCommand(string command, CancellationToken token);
    }
}
