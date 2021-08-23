using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterSapRegion
    {
        public string Regioncode { get; set; }
        public string Regionname { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
