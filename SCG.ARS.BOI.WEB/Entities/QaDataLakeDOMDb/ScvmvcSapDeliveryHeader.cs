using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class ScvmvcSapDeliveryHeader
    {
        public string DeliveryNumber { get; set; }
        public Instant? DeliveryCreateDate { get; set; }
        public string OrderNumber { get; set; }
        public Instant? OrderCreateDate { get; set; }
        public string PiMsgId { get; set; }
        public string IdocNo { get; set; }
        public string Serialization { get; set; }
        public string Action { get; set; }
        public string DeliveryType { get; set; }
        public string PoNumber { get; set; }
        public string Incoterm { get; set; }
        public string ShippingPoint { get; set; }
        public string ShipFromCode { get; set; }
        public string ShipFromName { get; set; }
        public string ShipFromStreet { get; set; }
        public string ShipFromCity { get; set; }
        public string ShipFromState { get; set; }
        public string ShipFromCountry { get; set; }
        public string ShipFromPostal { get; set; }
        public string ShipToCode { get; set; }
        public string ShipToName { get; set; }
        public string ShipToStreet { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToState { get; set; }
        public string ShipToCountry { get; set; }
        public string ShipToPostal { get; set; }
        public string ShipToTel { get; set; }
        public decimal? Volume { get; set; }
        public decimal? GrossWeight { get; set; }
        public string PrintableMemo { get; set; }
        public string NonprintableMemo { get; set; }
        public string SoldToCode { get; set; }
        public string SoldToName { get; set; }
        public string SoldToStreet { get; set; }
        public string SoldToCity { get; set; }
        public string SoldToState { get; set; }
        public string SoldToCountry { get; set; }
        public string SoldToPostal { get; set; }
        public string SoldToTel { get; set; }
        public string SalesOrg { get; set; }
        public Instant? DeliveryDatetime { get; set; }
        public Instant? PickingDatetime { get; set; }
        public Instant? GiDatetime { get; set; }
        public string PickingStatus { get; set; }
        public string GiStatus { get; set; }
        public string PaymentTerm { get; set; }
        public Instant? RequestDeliveryDate { get; set; }
        public string DmReceiverTelephone { get; set; }
        public Instant? DmScheduleDate { get; set; }
        public string UserCreateName { get; set; }
        public Instant? UserCreateDate { get; set; }
        public string UserUpdateName { get; set; }
        public Instant? UserUpdateDate { get; set; }
        public string VolumeUnit { get; set; }
        public string WeightUnit { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
