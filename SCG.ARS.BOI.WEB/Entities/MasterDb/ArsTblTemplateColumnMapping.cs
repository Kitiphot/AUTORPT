using System;
using System.Collections.Generic;

namespace SCG.ARS.BOI.WEB.Entities.MasterDb
{
    public partial class ArsTblTemplateColumnMapping
    {
        public long TemplateColumnMappingId { get; set; }
        public int TemplateReportMappingId { get; set; }
        public string ColumnName { get; set; }
        public string ColumnDataType { get; set; }
        public int ColumnSorting { get; set; }
        public string ColumnDisplay { get; set; }
        public bool? IsActive { get; set; }
        public string Footer { get; set; }
        public string DefaultValue { get; set; }
    }
}
