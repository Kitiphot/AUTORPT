using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordSapOrderAutosplittingCriteriaShiptoRegion
    {
        public string Sapbatchno { get; set; }
        public string Shiptoregion { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
