using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class ScvcorDeliveryTrackingLoadLeg
    {
        public string DeliveryNumber { get; set; }
        public string LoadId { get; set; }
        public Instant? LoadCreateDate { get; set; }
        public int? LoadLeg { get; set; }
        public string LoadDesc { get; set; }
        public string CarrierCode { get; set; }
        public string CarrierName { get; set; }
        public string TruckLicense { get; set; }
        public string DriverName { get; set; }
        public string EquipmentType { get; set; }
        public string MatFreightGrp { get; set; }
        public string CommodityCode { get; set; }
        public string PickupCode { get; set; }
        public string PickupName { get; set; }
        public string PickupRegion { get; set; }
        public string PickupPostalCode { get; set; }
        public string DropCode { get; set; }
        public string DropName { get; set; }
        public string DropRegion { get; set; }
        public string DropPostalCode { get; set; }
        public int? PickstopSeqNo { get; set; }
        public int? DropstopSeqNo { get; set; }
        public decimal? TripId { get; set; }
        public int? TripLoadSeqNo { get; set; }
        public bool? InactiveFlag { get; set; }
        public string UserCreateName { get; set; }
        public Instant? UserCreateDate { get; set; }
        public string UserUpdateName { get; set; }
        public Instant? UserUpdateDate { get; set; }
        public byte[] Rowversion { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
