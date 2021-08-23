namespace SCG.ARS.BOI.WEB.Models.Master {
    public class Menu {
        public int menu_id { get; set; }
        public int parent_id { get; set; }
        public string menu_code { get; set; }
        public string menu_name { get; set; }
        public string menu_icon { get; set; }
        public string menu_path { get; set; }
        public string menu_page { get; set; }
        public bool is_active { get; set; }
    }
}