using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordTransportServiceExpressInsource
    {
        public string Transportid { get; set; }
        public string Serviceid { get; set; }
        public int Logisticid { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
