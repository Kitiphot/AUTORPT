using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Models.ILB
{
    public class ILBRequestModel
    {
        public string selectStartDate { get; set; }
        public string selectEndDate { get; set; }
        public int? selectDaySearch { get; set; }
        public int? selectMonth { get; set; }
        public int? selectYear { get; set; }
        public string[] selectServiceGroup { get; set; }
        public int? selectCriteria { get; set; }
        public int? flagDate { get; set; }
    }
}
