using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class ScvmvcMasterTmsLocation
    {
        public string LocationCode { get; set; }
        public string LocationName { get; set; }
        public int? LocationType { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string SapLocationCode { get; set; }
        public string SapShippingCode { get; set; }
        public string SapShipToCode { get; set; }
        public bool? InactiveFlag { get; set; }
        public string UserCreateName { get; set; }
        public Instant? UserCreateDate { get; set; }
        public string UserUpdateName { get; set; }
        public Instant? UserUpdateDate { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
