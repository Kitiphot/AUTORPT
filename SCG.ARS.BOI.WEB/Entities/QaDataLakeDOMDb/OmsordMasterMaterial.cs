using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterMaterial
    {
        public string Materialcode { get; set; }
        public string Materialname { get; set; }
        public string Materialshortname { get; set; }
        public string Baseunit { get; set; }
        public string Pricingunit { get; set; }
        public decimal Netweight { get; set; }
        public decimal Grossweight { get; set; }
        public decimal? Volumeweight { get; set; }
        public string Weightunit { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public string Dimensionunit { get; set; }
        public decimal Volume { get; set; }
        public string Volumeunit { get; set; }
        public string Eancode { get; set; }
        public string Materialfreightgroup { get; set; }
        public int? Productgroupid { get; set; }
        public string Sapmaterialcode { get; set; }
        public bool Bomflag { get; set; }
        public bool Deleteflag { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool Freeflag { get; set; }
        public bool Vehicleflag { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
