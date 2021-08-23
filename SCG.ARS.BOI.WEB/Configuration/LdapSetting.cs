namespace SCG.ARS.BOI.WEB.Configuration {
    public class LdapSetting {
        public const string Section = "LdapSetting";
        public string Url { get; set; }
        public bool isSecure { get; set; }
        public string BindDn { get; set; }
        public string BindCredentials { get; set; }
        public string SearchBase { get; set; }
        public string SearchFilter { get; set; }
        public string AdminCn { get; set; }
    }
}