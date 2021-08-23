using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordTransportTruckType
    {
        public string Transportid { get; set; }
        public string Truckid { get; set; }
        public int Truckpriority { get; set; }
        public decimal Limitweight { get; set; }
        public string Weightunit { get; set; }
        public decimal Limitvolume { get; set; }
        public string Volumeunit { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
