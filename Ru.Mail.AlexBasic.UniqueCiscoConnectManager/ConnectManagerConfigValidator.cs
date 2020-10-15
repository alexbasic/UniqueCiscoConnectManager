namespace Ru.Mail.AlexBasic.UniqueCiscoConnectManager
{
    public class ConnectManagerConfigValidator
    {
        public bool Validate(ConnectManagerConfig config)
        {
            return
                IsNullOrWhiteSpace(config.VpnClientPath) &&
                IsNullOrWhiteSpace(config.PingAddress) &&
                IsPositiveNumber(config.ReconnectDelay) &&
                IsPositiveNumber(config.VerifyPeriod) &&
                IsNullOrWhiteSpace(config.VpnProfileName);
            
        }

        private bool IsNullOrWhiteSpace(string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }

        private bool IsPositiveNumber(int value)
        {
            return value >= 0;
        }
    }
}
