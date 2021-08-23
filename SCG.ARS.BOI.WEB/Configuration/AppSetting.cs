namespace SCG.ARS.BOI.WEB.Configuration {
    public class AppSetting {
        public const string Section = "appSetting";
        public string fileType { get; set; }
        public string[] uploadFileType { get; set; }
        public string MT { get; set; }
        public string billPayment { get; set; }
        public string CA { get; set; }
        public string CBS { get; set; }
        public string PG { get; set; }
        public string[] bankList { get; set; }
        public int BackGroudServiceTiming { get; set; }
    }
}