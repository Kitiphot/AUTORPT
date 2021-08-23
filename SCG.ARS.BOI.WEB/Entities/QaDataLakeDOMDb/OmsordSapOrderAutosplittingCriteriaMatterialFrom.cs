using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordSapOrderAutosplittingCriteriaMatterialFrom
    {
        public string Sapbatchno { get; set; }
        public string Materialnumber { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
