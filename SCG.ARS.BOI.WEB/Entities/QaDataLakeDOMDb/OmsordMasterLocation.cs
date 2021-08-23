using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterLocation
    {
        public string Locationcode { get; set; }
        public string Locationname { get; set; }
        public string Amphurcode { get; set; }
        public string Provincecode { get; set; }
        public string Districtcode { get; set; }
        public int Locationtype { get; set; }
        public bool? Originflag { get; set; }
        public bool? Destinationflag { get; set; }
        public string Houseno { get; set; }
        public string Soi { get; set; }
        public string Street { get; set; }
        public string Postalcode { get; set; }
        public int? Region { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string Saplocationcode { get; set; }
        public string Sapshippingpoint { get; set; }
        public string Sapshipto { get; set; }
        public bool Deleteflag { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Receipient { get; set; }
        public string Telephone { get; set; }
        public string Vehicletypecode { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
