using Newtonsoft.Json;

namespace SCG.ARS.BOI.WEB.Configuration {
    public class SmtpSetting {
        public const string Section = "SmtpSetting";

        [JsonProperty (PropertyName = "Smtp:Domain")]
        public string Domain { get; set; }

        [JsonProperty (PropertyName = "Smtp:From")]
        public string From { get; set; }

        [JsonProperty (PropertyName = "Smtp:Host")]
        public string Host { get; set; }

        [JsonProperty (PropertyName = "Smtp:Port")]
        public int Port { get; set; }

        [JsonProperty (PropertyName = "Smtp:EnableSSL")]
        public bool EnableSsl { get; set; }

        [JsonProperty (PropertyName = "Smtp:Username")]
        public string Username { get; set; }

        [JsonProperty (PropertyName = "Smtp:Password")]
        public string Password { get; set; }
    }
}