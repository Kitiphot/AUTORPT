namespace SCG.ARS.BOI.WEB.Models.Master {
    public class FunctionTemplate {
        public int function_template_id { get; set; }
        public int function_template_name { get; set; }
        public int function_id { get; set; }
        public int template_id { get; set; }
        public int customer_id { get; set; }
        public int report_id { get; set; }
        //public int report_type_id { get; set; }
        public bool is_active { get; set; }
    }
}