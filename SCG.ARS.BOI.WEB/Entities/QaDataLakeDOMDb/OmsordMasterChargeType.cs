using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterChargeType
    {
        public string Chargetype { get; set; }
        public string Chargedescription { get; set; }
        public string Chargeunit { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
