using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterSapSubRegion
    {
        public string Regioncode { get; set; }
        public string Subregioncode { get; set; }
        public string Subregionname { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
