using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmscitMasterSapCarrier
    {
        public string Carriercode { get; set; }
        public string Carriername { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
