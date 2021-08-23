using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class ScvmvcSapDeliveryItem
    {
        public string DeliveryNumber { get; set; }
        public string DeliveryItemNumber { get; set; }
        public string ItemMatNo { get; set; }
        public string ItemMatDesc { get; set; }
        public string ItemMatFreightGrp { get; set; }
        public string Plant { get; set; }
        public decimal? ItemGrossWeight { get; set; }
        public decimal? ItemQuantity { get; set; }
        public string SalesUnit { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
