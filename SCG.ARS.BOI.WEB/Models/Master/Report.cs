namespace SCG.ARS.BOI.WEB.Models.Master {
    public class Report {
        public int? report_id { get; set; }
        public string report_name { get; set; }
        public string report_name2 { get; set; }
        public int schema_id { get; set; }
        public string schema_name { get; set; }
        public bool is_active { get; set; }

        //== Generwiz - Pittaya J. 2021-02-19 ==
        public int group_id { get; set; }
        public string function_name { get; set; }
        public string updated_by { get; set; }
        public string updated_date { get; set; }
        public string created_by { get; set; }
        public string created_date { get; set; }
    }
}