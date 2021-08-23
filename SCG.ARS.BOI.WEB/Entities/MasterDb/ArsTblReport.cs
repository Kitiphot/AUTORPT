using System;
using System.Collections.Generic;

namespace SCG.ARS.BOI.WEB.Entities.MasterDb
{
    public partial class ArsTblReport
    {
        public int ReportId { get; set; }
        public string ReportName { get; set; }
        public int SchemaId { get; set; }
        public bool? IsActive { get; set; }
    }
}
