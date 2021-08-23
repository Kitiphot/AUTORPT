using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordConfigShippingPointAuto
    {
        public string Configtype { get; set; }
        public string Shippingpoint { get; set; }
        public string Remark { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
