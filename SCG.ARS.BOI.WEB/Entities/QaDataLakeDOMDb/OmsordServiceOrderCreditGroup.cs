using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordServiceOrderCreditGroup
    {
        public string Creditgroupcode { get; set; }
        public string Cca { get; set; }
        public string Creditrepgroupcode { get; set; }
        public string Creditcheckdate { get; set; }
        public string Customerrisk { get; set; }
        public string Approvalposition { get; set; }
        public string Paymentterm { get; set; }
        public decimal? Creditexceedamount { get; set; }
        public decimal? Overduebaht { get; set; }
        public int? Overdueday { get; set; }
        public decimal? Aramount { get; set; }
        public decimal? Collateralamount { get; set; }
        public string Customercode { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
