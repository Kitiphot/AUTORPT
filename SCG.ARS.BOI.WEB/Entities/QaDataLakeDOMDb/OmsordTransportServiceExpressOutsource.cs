using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordTransportServiceExpressOutsource
    {
        public string Transportid { get; set; }
        public string Serviceid { get; set; }
        public int Logisticid { get; set; }
        public int Ordering { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
