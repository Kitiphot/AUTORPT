using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class ScvmvcTmsLoadLeg
    {
        public string LoadId { get; set; }
        public string CarrierCode { get; set; }
        public string CarrierName { get; set; }
        public string DriverName { get; set; }
        public string TruckLicense { get; set; }
        public string EquipmentType { get; set; }
        public decimal? ChargeAmount { get; set; }
        public decimal? TotalDistance { get; set; }
        public decimal? TotalVolume { get; set; }
        public decimal? TotalWeight { get; set; }
        public int? TotalShipments { get; set; }
        public int? TotalStops { get; set; }
        public string LoadStatus { get; set; }
        public int? LoadSeqNo { get; set; }
        public decimal? TripId { get; set; }
        public string LoadDesc { get; set; }
        public bool? InactiveFlag { get; set; }
        public string EventName { get; set; }
        public Instant? EventDate { get; set; }
        public string UserCreateName { get; set; }
        public Instant? UserCreateDate { get; set; }
        public string UserUpdateName { get; set; }
        public Instant? UserUpdateDate { get; set; }
        public byte[] Rowversion { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
