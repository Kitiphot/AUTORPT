using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Entities.MasterDb
{
    public partial class ArsTblReportGroupMapping
    {
        public int GroupId { get; set; }
        public string ReportName { get; set; }
        public string FunctionName { get; set; }
        public bool IsActive { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
