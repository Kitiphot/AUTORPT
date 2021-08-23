using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterCharge
    {
        public string Chargecode { get; set; }
        public string Chargename { get; set; }
        public string Lastupdateddate { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
