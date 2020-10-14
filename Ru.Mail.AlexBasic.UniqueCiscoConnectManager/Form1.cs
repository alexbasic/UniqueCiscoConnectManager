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

    public partial class Form1 : Form
    {
        private ConnectManager _manager;
        private CancellationTokenSource _tokenSource = new CancellationTokenSource();
        private object lockObject = new object();
        private LogToTextBoxWriterDelegate _logToTextBoxWriter;

        public Form1()
        {
            InitializeComponent();

            _manager = new ConnectManager(
                "C:\\Program Files (x86)\\Cisco Systems\\VPN Client\\vpnclient",
                "site.intranet.loc",
                5000,
                30000,
                "Profile name",
                (s, p) => LogToTextEdit((ConnectManager)s, p));

            _logToTextBoxWriter = (manager, value) => 
            {
                pictureBox1.BackColor = manager.Connected ? Color.Green : Color.Red;
                textBox1.AppendText($"{DateTime.Now} > {value}\r\n");
            };
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            _tokenSource = new CancellationTokenSource();
            await _manager.Start(_tokenSource.Token, (s, p) => LogToTextEdit((ConnectManager)s, p));
            button1.Enabled = true;
            button2.Enabled = false;
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
    }
}
