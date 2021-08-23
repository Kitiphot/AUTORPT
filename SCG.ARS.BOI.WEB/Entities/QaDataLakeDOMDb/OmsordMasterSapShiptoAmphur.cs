using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterSapShiptoAmphur
    {
        public string Shiptocode { get; set; }
        public string Amphurcode { get; set; }
        public string Provincecode { get; set; }
        public bool? Deleteflag { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
