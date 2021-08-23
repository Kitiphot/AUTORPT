using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordEstTransportService
    {
        public long Id { get; set; }
        public string Sonumber { get; set; }
        public long? Soitemid { get; set; }
        public int Serviceitemid { get; set; }
        public string Serviceitemname { get; set; }
        public int? Servicetypeid { get; set; }
        public string Servicetypename { get; set; }
        public decimal? Remainquantity { get; set; }
        public string Baseunit { get; set; }
        public decimal? Price { get; set; }
        public decimal? Remainprice { get; set; }
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
        public Instant? DmsRepDtt { get; set; }
    }
}
