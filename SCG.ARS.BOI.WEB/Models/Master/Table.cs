namespace SCG.ARS.BOI.WEB.Models.Master {
    public class Table {
        public string table_catalog { get; set; }
        public string table_schema { get; set; }
        public string table_name { get; set; }
        public string table_type { get; set; }
        public bool is_active{ get; set; }
        //public bool is_deleted{ get; set; }
    }
}