using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterOriginLocation
    {
        public string Locationcode { get; set; }
        public string Customercode { get; set; }
        public string Sapshippingpointcode { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
