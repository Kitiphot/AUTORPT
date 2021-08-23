namespace SCG.ARS.BOI.WEB.Configuration
{
    public class ConnectionStrings
    {
        public const string Section = "ConnectionStrings";
        public string DefaultConnection { get; set; }
        public string PDLakeConnection { get; set; }
        public string ARSConnection { get; set; }

        public string PDLakeWConnection { get; set; }
        public string PKGConnection { get; set; }
        public string PDLakeNetworkingConnection { get; set; }
        public string DFConnection { get; set; }
    }
}