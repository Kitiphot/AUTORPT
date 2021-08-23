using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class ScvmvcExtDeliveryItem
    {
        public string DeliveryNumber { get; set; }
        public string DeliveryType { get; set; }
        public int LegId { get; set; }
        public int DeliveryItemNumber { get; set; }
        public string LegHeader { get; set; }
        public string RefDeliveryNumber { get; set; }
        public string OrderNumber { get; set; }
        public string OrderItemNumber { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public string MatFreightGrp { get; set; }
        public decimal? MatNetWeight { get; set; }
        public decimal? MatGrossWeight { get; set; }
        public decimal? MatVolume { get; set; }
        public string MatBaseUnit { get; set; }
        public string MatPricingUnit { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? GiQuantity { get; set; }
        public decimal? TotalNetWeight { get; set; }
        public decimal? TotalGrossWeight { get; set; }
        public string WeightUnit { get; set; }
        public decimal? TotalVolume { get; set; }
        public string VolumeUnit { get; set; }
        public string PlannerName { get; set; }
        public string ShippingMark { get; set; }
        public string Remark { get; set; }
        public bool? FlagGi { get; set; }
        public bool? FlagRequestPallet { get; set; }
        public bool? FlagDelete { get; set; }
        public Instant? GiCompletedDate { get; set; }
        public decimal? GrQuantity { get; set; }
        public bool? FlagGr { get; set; }
        public Instant? GrCompletedDate { get; set; }
        public decimal? PackedQuantity { get; set; }
        public Instant? DmsRepDtt { get; set; }
        public string Plant { get; set; }
        public string UserCreateName { get; set; }
        public Instant? UserCreateDate { get; set; }
        public string UserUpdateName { get; set; }
        public Instant? UserUpdateDate { get; set; }
        public Instant? KafkaTimeStamp { get; set; }
    }
}
