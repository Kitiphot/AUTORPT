using System;
using System.Collections.Generic;

namespace SCG.ARS.BOI.WEB.Entities.MasterDb
{
    public partial class ArsTblFunction
    {
        public int FunctionId { get; set; }
        public string FunctionName { get; set; }
        public bool? IsActive { get; set; }
        public int SchemaId { get; set; }
        public int ReportId { get; set; }
    }
}
