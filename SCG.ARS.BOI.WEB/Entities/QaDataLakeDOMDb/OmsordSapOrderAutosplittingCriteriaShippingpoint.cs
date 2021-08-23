using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordSapOrderAutosplittingCriteriaShippingpoint
    {
        public string Sapbatchno { get; set; }
        public string Shippingpoint { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
