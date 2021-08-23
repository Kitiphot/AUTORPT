using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class ScvmvcTmsDeliveryHeader
    {
        public string DeliveryNumber { get; set; }
        public decimal DeliveryShpmId { get; set; }
        public Instant? DeliveryCreateDate { get; set; }
        public string OrderNumber { get; set; }
        public Instant? OrderCreateDate { get; set; }
        public string SoldToCode { get; set; }
        public string SoldToName { get; set; }
        public string ShipToCode { get; set; }
        public string ShipToName { get; set; }
        public string ShippingPoint { get; set; }
        public string ShippingName { get; set; }
        public string CommodityCode { get; set; }
        public string Region { get; set; }
        public string PostalCdFrom { get; set; }
        public string PostalCdTo { get; set; }
        public string PoNumber { get; set; }
        public string MatFreightGrp { get; set; }
        public string ShipToBlock { get; set; }
        public string ShipToStreet { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToRegion { get; set; }
        public string ShipToCountry { get; set; }
        public string ShippingBlock { get; set; }
        public string ShippingStreet { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingRegion { get; set; }
        public string ShippingCountry { get; set; }
        public string DataSource { get; set; }
        public bool? InactiveFlag { get; set; }
        public string EventName { get; set; }
        public Instant? EventDate { get; set; }
        public string UserCreateName { get; set; }
        public Instant? UserCreateDate { get; set; }
        public string UserUpdateName { get; set; }
        public Instant? UserUpdateDate { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
