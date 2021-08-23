using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordActTransportService
    {
        public long Id { get; set; }
        public string Layer { get; set; }
        public string Shipmentnumber { get; set; }
        public string Dnnumber { get; set; }
        public int? Dnitem { get; set; }
        public int Serviceitemid { get; set; }
        public string Serviceitemname { get; set; }
        public int? Servicetypeid { get; set; }
        public string Servicetypename { get; set; }
        public decimal? Quantity { get; set; }
        public string Baseunit { get; set; }
        public decimal? Price { get; set; }
        public string Pricecaltype { get; set; }
        public string Fueltype { get; set; }
        public decimal? Fuelrate { get; set; }
        public decimal? Pricerate { get; set; }
        public decimal? Pricebyweight { get; set; }
        public string Interfaceid { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Gidate { get; set; }
        public bool Arflag { get; set; }
        public decimal? Pricequantity { get; set; }
        public string Pricingunit { get; set; }
        public string Vehicletypecode { get; set; }
        public string Vehicletypename { get; set; }
        public string Sonumber { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
