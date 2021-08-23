using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class ScvmvcTmsLoadLegDetail
    {
        public string LoadId { get; set; }
        public string DeliveryNumber { get; set; }
        public decimal? ShipmentId { get; set; }
        public string OrderNumber { get; set; }
        public string PoNumber { get; set; }
        public int? LoadLeg { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string OriginCode { get; set; }
        public string OriginName { get; set; }
        public string OriginBlock { get; set; }
        public string OriginStreet { get; set; }
        public string OriginCity { get; set; }
        public string OriginRegion { get; set; }
        public string OriginCountry { get; set; }
        public string OriginPostalCode { get; set; }
        public string DestinationCode { get; set; }
        public string DestinationName { get; set; }
        public string DestinationBlock { get; set; }
        public string DestinationStreet { get; set; }
        public string DestinationCity { get; set; }
        public string DestinationRegion { get; set; }
        public string DestinationCountry { get; set; }
        public string DestinationPostalCode { get; set; }
        public string CommodityCode { get; set; }
        public string MatFreightGrp { get; set; }
        public string ShipmentPrtbCtnt { get; set; }
        public string ShipmentNonPrtbCtnt { get; set; }
        public int? DropSeqNo { get; set; }
        public int? StopSeqNo { get; set; }
        public string StopExtlCd1 { get; set; }
        public Instant? DeliveryFromDate { get; set; }
        public decimal? FromPrevStopDistance { get; set; }
        public decimal? ShipmentWeight { get; set; }
        public string PickupCode { get; set; }
        public string PickupName { get; set; }
        public string PickupBlock { get; set; }
        public string PickupStreet { get; set; }
        public string PickupCity { get; set; }
        public string PickupRegion { get; set; }
        public string PickupCountry { get; set; }
        public string PickupPostalCode { get; set; }
        public string DropCode { get; set; }
        public string DropName { get; set; }
        public string DropBlock { get; set; }
        public string DropStreet { get; set; }
        public string DropCity { get; set; }
        public string DropRegion { get; set; }
        public string DropCountry { get; set; }
        public string DropPostalCode { get; set; }
        public int? PickSeqNo { get; set; }
        public int? PickstopSeqNo { get; set; }
        public int? DropstopSeqNo { get; set; }
        public bool? InactiveFlag { get; set; }
        public byte[] Rowversion { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
