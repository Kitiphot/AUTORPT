using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class ScvmvcTmsDeliveryItem
    {
        public string DeliveryNumber { get; set; }
        public string DeliveryItemNumber { get; set; }
        public string ItemNumber { get; set; }
        public string ItemDesc { get; set; }
        public decimal? ItemQuantity { get; set; }
        public decimal? ItemWeight { get; set; }
        public string ContainerDesc { get; set; }
        public decimal? ContainerQuantity { get; set; }
        public decimal? ContainerWeight { get; set; }
        public decimal? ContainerVolume { get; set; }
        public string ContainerCommodityCode { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
