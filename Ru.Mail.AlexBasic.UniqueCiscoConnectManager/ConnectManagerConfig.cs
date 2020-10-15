using System;

namespace Ru.Mail.AlexBasic.UniqueCiscoConnectManager
{
    public class ConnectManagerConfig
    {
        public string VpnClientPath { get; set; }
        public string PingAddress { get; set; }
        public int ReconnectDelay { get; set; }
        public int VerifyPeriod { get; set; }
        public string VpnProfileName { get; set; }
        public bool EnableBypassTime { get; set; }
        public TimeSpan BypassFrom { get; set; }
        public TimeSpan BypassTo { get; set; }
    }
}
