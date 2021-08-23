using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordLegSplitting
    {
        public string Legheader { get; set; }
        public int Legid { get; set; }
        public string Sonumber { get; set; }
        public string Transportid { get; set; }
        public bool IsUsed { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
