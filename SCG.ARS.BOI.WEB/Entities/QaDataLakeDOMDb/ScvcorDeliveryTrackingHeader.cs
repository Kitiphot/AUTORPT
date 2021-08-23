using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class ScvcorDeliveryTrackingHeader
    {
        public string DeliveryNumber { get; set; }
        public string OrderNumber { get; set; }
        public string PoNumber { get; set; }
        public Instant? DeliveryCreateDate { get; set; }
        public Instant? OrderCreateDate { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string MatFreightGrp { get; set; }
        public string CommodityCode { get; set; }
        public string OriginCode { get; set; }
        public string OriginName { get; set; }
        public string OriginRegion { get; set; }
        public string OriginPostalCode { get; set; }
        public string DestinationCode { get; set; }
        public string DestinationName { get; set; }
        public string DestinationRegion { get; set; }
        public string DestinationPostalCode { get; set; }
        public string SalesOrg { get; set; }
        public int? TotalOfLeg { get; set; }
        public bool? InactiveFlag { get; set; }
        public string UserCreateName { get; set; }
        public Instant? UserCreateDate { get; set; }
        public string UserUpdateName { get; set; }
        public Instant? UserUpdateDate { get; set; }
        public byte[] Rowversion { get; set; }
        public string CustomerRegion { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
