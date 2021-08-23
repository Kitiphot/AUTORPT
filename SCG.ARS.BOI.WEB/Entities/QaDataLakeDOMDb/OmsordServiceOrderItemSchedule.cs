using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordServiceOrderItemSchedule
    {
        public long Soitemid { get; set; }
        public long Scheduleid { get; set; }
        public decimal Quantity { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
