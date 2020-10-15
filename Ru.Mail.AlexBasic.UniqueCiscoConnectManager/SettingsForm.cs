using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ru.Mail.AlexBasic.UniqueCiscoConnectManager
{
    public partial class SettingsForm : Form
    {
        private ConnectManagerConfig _config;

        public SettingsForm(ConnectManagerConfig config)
        {
            InitializeComponent();

            _config = config;

            reconnectDelay_numericUpDown.Maximum = int.MaxValue;
            verifyPeriod_numericUpDown.Maximum = int.MaxValue;

            pathToClient_textBox.Text = config.VpnClientPath;
            pingAddress_textBox.Text = config.PingAddress;
            reconnectDelay_numericUpDown.Value = config.ReconnectDelay;
            verifyPeriod_numericUpDown.Value = config.VerifyPeriod;
            vpnProfileName_textBox.Text = config.VpnProfileName;
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.None && this.DialogResult == DialogResult.OK)
            {
                var config = new ConnectManagerConfig 
                {
                    VpnClientPath = pathToClient_textBox.Text,
                    PingAddress = pingAddress_textBox.Text,
                    ReconnectDelay = (int)reconnectDelay_numericUpDown.Value,
                    VerifyPeriod = (int)verifyPeriod_numericUpDown.Value,
                    VpnProfileName = vpnProfileName_textBox.Text
                };
                if (!new ConnectManagerConfigValidator().Validate(config))
                {
                    e.Cancel = true;
                    MessageBox.Show(this, "Config has errors. Change values.", "Config has errors");
                    return;
                }
                _config.VpnClientPath = config.VpnClientPath;
                _config.PingAddress = config.PingAddress;
                _config.ReconnectDelay = config.ReconnectDelay;
                _config.VerifyPeriod = config.VerifyPeriod;
                _config.VpnProfileName = config.VpnProfileName;

            }
        }
    }
}
