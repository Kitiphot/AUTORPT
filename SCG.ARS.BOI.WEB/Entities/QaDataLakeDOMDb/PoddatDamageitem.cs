using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class PoddatDamageitem
    {
        public string Shipmentno { get; set; }
        public string Deliveryno { get; set; }
        public string Deliveryitem { get; set; }
        public string Documentno { get; set; }
        public string Damagecause { get; set; }
        public decimal? Apcreditamount { get; set; }
        public decimal? Apcdebitamount { get; set; }
        public decimal? Arcreditamount { get; set; }
        public decimal? Arcdebitamount { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
