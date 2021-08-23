using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterSapShippingpoint
    {
        public string Sapshippingpointcode { get; set; }
        public string Sapshippingpointname { get; set; }
        public int Systemid { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
