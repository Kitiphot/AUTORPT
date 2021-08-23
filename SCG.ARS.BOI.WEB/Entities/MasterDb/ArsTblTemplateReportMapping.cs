using System;
using System.Collections.Generic;

namespace SCG.ARS.BOI.WEB.Entities.MasterDb
{
    public partial class ArsTblTemplateReportMapping
    {
        public int TemplateReportMappingId { get; set; }
        public int SchemaId { get; set; }
        public int? FunctionId { get; set; }
        public int? ReportId { get; set; }
        public int? GroupId { get; set; }
        public string FunctionName { get; set; }
        public string ReportDesc { get; set; }
        public bool? IsActive { get; set; }
        public string TemplateName { get; set; }
        public string TemplatePath { get; set; }
    }
}
