using System;
using System.Collections.Generic;

namespace SCG.ARS.BOI.WEB.Entities.MasterDb
{
    public partial class ArsTblTemplate
    {
        public int TemplateId { get; set; }
        public string TemplateName { get; set; }
        public string TemplatePath { get; set; }
        public bool? IsActive { get; set; }
        public int TemplateReportMappingId { get; set; }
    }
}
