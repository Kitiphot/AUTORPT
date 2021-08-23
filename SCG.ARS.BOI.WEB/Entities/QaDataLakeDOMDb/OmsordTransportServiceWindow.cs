using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordTransportServiceWindow
    {
        public string Transportid { get; set; }
        public string Arrivalday { get; set; }
        public string Departureday { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
