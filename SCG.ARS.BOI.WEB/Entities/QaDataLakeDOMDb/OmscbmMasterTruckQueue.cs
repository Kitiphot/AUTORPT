using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmscbmMasterTruckQueue
    {
        public int Queueno { get; set; }
        public int Fleetid { get; set; }
        public LocalDate Committeddate { get; set; }
        public string Vehicletypecode { get; set; }
        public string Orderno { get; set; }
        public string Orderline { get; set; }
        public string Createddate { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
