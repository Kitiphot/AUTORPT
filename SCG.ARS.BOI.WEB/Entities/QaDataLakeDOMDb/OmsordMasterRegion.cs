using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterRegion
    {
        public int Regioncode { get; set; }
        public string Regionname { get; set; }
        public string Countrycode { get; set; }
        public string Sapcode { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
