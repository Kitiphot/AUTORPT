namespace SCG.ARS.BOI.WEB.Models.Master
{
    public class MasterFunction
    {
        public int? function_id { get; set; }
        public string function_name { get; set; }
        public int schema_id { get; set; }
        public string schema_name { get; set; }
        public string schema_display { get; set; }
        public string catalog_name { get; set; }
        public string schema_owner { get; set; }
        public int schema_order { get; set; }
        public int report_id { get; set; }
        public string report_name { get; set; }
        public int group_id { get; set; }
        public string group_name { get; set; }
        public int report_group_id { get; set; }
        public string report_group_name { get; set; }
        public bool is_active { get; set; }
        public string update_name { get; set; }
        public string update_date { get; set; }
    }
}