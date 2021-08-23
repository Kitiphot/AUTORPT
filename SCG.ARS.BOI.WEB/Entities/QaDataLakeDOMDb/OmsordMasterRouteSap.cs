using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterRouteSap
    {
        public string Routecode { get; set; }
        public string Routedescription { get; set; }
        public int Transittime { get; set; }
        public string Destinationcode { get; set; }
        public string Originlocationcode { get; set; }
        public string Thoughtpointlocationcode { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
