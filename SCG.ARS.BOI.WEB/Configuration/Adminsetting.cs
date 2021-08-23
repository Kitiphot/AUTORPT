namespace SCG.ARS.BOI.WEB.Configuration {
    public class AdminSetting {
        public const string Section = "adminSetting";
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserEmail { get; set; }
        public int UserGroupId { get; set; }
    }
}