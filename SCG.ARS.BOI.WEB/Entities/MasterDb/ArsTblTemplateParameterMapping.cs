using System;
using System.Collections.Generic;

namespace SCG.ARS.BOI.WEB.Entities.MasterDb
{
    public partial class ArsTblTemplateParameterMapping
    {
        public int TemplateParameterMappingId { get; set; }
        public int TemplateReportMappingId { get; set; }
        public string ParameterName { get; set; }
        public int ParameterTypeId { get; set; }
        public int ParameterDataTypeId { get; set; }
        public string ParameterDefaultValue { get; set; }
        public int? ParameterSourceId { get; set; }
        public string ParameterSourceColumn { get; set; }
        public string ParameterSourceQuery { get; set; }
        public bool? IsActive { get; set; }
        public int OrdinalPosition { get; set; }
        public string ParameterUdtName { get; set; }
    }
}
