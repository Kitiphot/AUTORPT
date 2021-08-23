using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordTransportServiceLeadtime
    {
        public string Transportid { get; set; }
        public int Leadtime { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
