namespace Ru.Mail.AlexBasic.UniqueCiscoConnectManager
{
    public class ConnectManagerConfig
    {
        public string VpnClientPath { get; set; }
        public string PingAddress { get; set; }
        public int ReconnectDelay { get; set; }
        public int VerifyPeriod { get; set; }
        public string VpnProfileName { get; set; }
    }
}
