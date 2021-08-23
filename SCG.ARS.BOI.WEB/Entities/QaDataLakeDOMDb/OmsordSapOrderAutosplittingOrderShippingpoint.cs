using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordSapOrderAutosplittingOrderShippingpoint
    {
        public string Sapbatchno { get; set; }
        public string Orderno { get; set; }
        public string Orderline { get; set; }
        public string Value { get; set; }
        public string Label { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
