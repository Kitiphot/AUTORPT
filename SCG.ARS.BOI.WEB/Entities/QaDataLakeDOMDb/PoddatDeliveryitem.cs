using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class PoddatDeliveryitem
    {
        public string Deliveryno { get; set; }
        public string Deliveryitem { get; set; }
        public string Itemcode { get; set; }
        public string Itemtext { get; set; }
        public string Commuditycode { get; set; }
        public decimal Itemquantity { get; set; }
        public decimal Itemweight { get; set; }
        public decimal Itemvolume { get; set; }
        public decimal Unitquantity { get; set; }
        public decimal Unitweight { get; set; }
        public decimal Unitvolume { get; set; }
        public string Quantityunit { get; set; }
        public string Weightunit { get; set; }
        public string Volumeunit { get; set; }
        public string Plantcode { get; set; }
        public decimal? Damageqty { get; set; }
        public string Damageunit { get; set; }
        public decimal? Sapgrossweight { get; set; }
        public decimal? Sapitemquantity { get; set; }
        public string Documentno { get; set; }
        public string Returnunit { get; set; }
        public decimal? Returnqty { get; set; }
        public bool? Isreturnitem { get; set; }
        public bool? Isdamageitem { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
