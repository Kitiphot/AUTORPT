using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordServiceOrderItemShipMark
    {
        public long Id { get; set; }
        public long Soitemid { get; set; }
        public string Shippingmark { get; set; }
        public string Palletid { get; set; }
        public decimal Quantity { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
