using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordSapOrderCharge
    {
        public string Orderno { get; set; }
        public string Chargetype { get; set; }
        public decimal? Chargeamount { get; set; }
        public string Chargeunit { get; set; }
        public string Applyapoption { get; set; }
        public string Updateby { get; set; }
        public string Updatedate { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
