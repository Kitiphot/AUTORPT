using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordCustomerServiceLeadtime
    {
        public string Customercode { get; set; }
        public string Routeid { get; set; }
        public bool IsStandard { get; set; }
        public int? Leadtime { get; set; }
        public string Ordercutofftime { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
