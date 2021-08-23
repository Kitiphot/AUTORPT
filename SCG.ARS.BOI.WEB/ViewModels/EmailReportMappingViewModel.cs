using SCG.ARS.BOI.WEB.Models.Master;

namespace SCG.ARS.BOI.WEB.ViewModels
{
    public class EmailReportMappingViewModel : EmailReportMapping
    {
        public string email_address { get; set; }
        public string template_name { get; set; }
        public string template_path { get; set; }
    }
}