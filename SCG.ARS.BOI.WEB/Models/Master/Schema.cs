namespace SCG.ARS.BOI.WEB.Models.Master
{
    public class Schema
    {
        public int? schema_id { get; set; }
        public string catalog_name { get; set; }
        public string schema_name { get; set; }
        public string schema_owner { get; set; }
        public string schema_display { get; set; }
        public string schema_display_edit { get; set; }
        public int schema_order { get; set; }
        public bool is_active { get; set; }
        public bool is_deleted { get; set; }
        public string update_name { get; set; }
        public string update_by { get; set; }
        public string update_date { get; set; }
    }
}