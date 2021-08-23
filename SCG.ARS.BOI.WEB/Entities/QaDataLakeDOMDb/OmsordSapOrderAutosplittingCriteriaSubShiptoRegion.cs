using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordSapOrderAutosplittingCriteriaSubShiptoRegion
    {
        public string Sapbatchno { get; set; }
        public string Subshiptoregion { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
