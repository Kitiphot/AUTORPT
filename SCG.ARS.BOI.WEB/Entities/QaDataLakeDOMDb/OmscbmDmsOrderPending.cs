using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmscbmDmsOrderPending
    {
        public string Orderno { get; set; }
        public bool Pendingstatus { get; set; }
        public string Soldtocode { get; set; }
        public string Createddate { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
