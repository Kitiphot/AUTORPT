namespace SCG.ARS.BOI.WEB.Models.Master
{
    public class Parameter
    {
        public string specific_catalog { get; set; }
        public string specific_schema { get; set; }
        public string routine_name { get; set; }
        public string routine_type { get; set; }
        public string parameter_mode { get; set; }
        public string parameter_name { get; set; }
        public string data_type { get; set; }
        public string udt_name { get; set; }
        public int ordinal_position { get; set; }
    }
}