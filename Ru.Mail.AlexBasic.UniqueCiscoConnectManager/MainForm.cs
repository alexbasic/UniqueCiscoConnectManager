using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Ru.Mail.AlexBasic.UniqueCiscoConnectManager
{
    public delegate void LogToTextBoxWriterDelegate(ConnectManager manager, string value);

    public partial class MainForm : Form
    {
        private ConnectManager _manager;
        private CancellationTokenSource _tokenSource = new CancellationTokenSource();
        private object lockObject = new object();
        private LogToTextBoxWriterDelegate _logToTextBoxWriter;
        private ConnectManagerConfig _config;

        public MainForm()
        {
            InitializeComponent();

            _config = new ConnectManagerConfig 
            {
                VpnClientPath = Properties.Settings.Default.VpnClientPath,
                PingAddress = Properties.Settings.Default.PingAddress,
                ReconnectDelay = Properties.Settings.Default.ReconnectDelay,
                VerifyPeriod = Properties.Settings.Default.VerifyPeriod,
                VpnProfileName = Properties.Settings.Default.VpnProfileName,
                EnableBypassTime = Properties.Settings.Default.EnableBypassTime,
                BypassFrom = Properties.Settings.Default.BypassFrom,
                BypassTo = Properties.Settings.Default.BypassTo
            };

            _manager = ConnectManagerFactory(_config);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            settingsToolStripMenuItem.Enabled = false;
            _tokenSource = new CancellationTokenSource();
            try
            {
                await _manager.Start(_tokenSource.Token, (s, p) => LogToTextEdit((ConnectManager)s, p));
            }
            catch (Exception ex) 
            {
                LogToTextEdit(_manager, "Client start error.");
                MessageBox.Show(this, $"Error on starting vpn client. Check path to vpn client. Message: {ex?.Message ?? ""}", "Start error");
            }
            button1.Enabled = true;
            button2.Enabled = false;
            settingsToolStripMenuItem.Enabled = true;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            _tokenSource.Cancel();
        }

        private void LogToTextEdit(ConnectManager manager, string value)
        {
            lock (lockObject) {
                textBox1.Invoke(_logToTextBoxWriter, manager, value);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_manager.Connected) return;

            var settingsForm = new SettingsForm(_config);
            var dialogResult = settingsForm.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                _manager = ConnectManagerFactory(_config);
                SaveSettings(_config);
            }

        }

        private ConnectManager ConnectManagerFactory(ConnectManagerConfig config)
        {
            _manager = new ConnectManager(
                _config.VpnClientPath,
                _config.PingAddress,
                _config.ReconnectDelay,
                _config.VerifyPeriod,
                _config.VpnProfileName,
                (s, p) => LogToTextEdit((ConnectManager)s, p));

            _logToTextBoxWriter = (manager, value) =>
            {
                pictureBox1.BackColor = manager.Connected ? Color.Green : Color.Red;
                textBox1.AppendText($"{DateTime.Now} > {value}\r\n");
            };

            return _manager;
        }

        private void SaveSettings(ConnectManagerConfig config)
        {
            Properties.Settings.Default.VpnClientPath = config.VpnClientPath;
            Properties.Settings.Default.PingAddress = config.PingAddress; 
            Properties.Settings.Default.ReconnectDelay = config.ReconnectDelay;
            Properties.Settings.Default.VerifyPeriod = config.VerifyPeriod;
            Properties.Settings.Default.VpnProfileName = config.VpnProfileName;
            Properties.Settings.Default.EnableBypassTime = config.EnableBypassTime;
            Properties.Settings.Default.BypassFrom = config.BypassFrom;
            Properties.Settings.Default.BypassTo = config.BypassTo;

            Properties.Settings.Default.Save();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
