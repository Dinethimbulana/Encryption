using Microsoft.Extensions.Configuration;

namespace EncryptData.Encryption
{
    public static class EncryptionSettings
    {
        public static IConfiguration Configuration { get; set; }

        public static string EncryptKey
        {
            get
            {
                return Configuration.GetValue<string>("EncryptionSettings:EncryptKey");
            }
        }
        public static string EncryptIV
        {
            get
            {
                return Configuration.GetValue<string>("EncryptionSettings:EncryptIV");
            }
        }
    }
}
