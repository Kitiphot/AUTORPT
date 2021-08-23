using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterBigLot
    {
        public string RegionCode { get; set; }
        public decimal? Weight { get; set; }
        public string WeightUnit { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
