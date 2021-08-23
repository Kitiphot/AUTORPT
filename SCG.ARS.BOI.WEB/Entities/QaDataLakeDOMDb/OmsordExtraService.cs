using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordExtraService
    {
        public long Id { get; set; }
        public string Sonumber { get; set; }
        public long? Soitemid { get; set; }
        public int? Serviceitemid { get; set; }
        public string Serviceitemname { get; set; }
        public string Description { get; set; }
        public int? Servicetypeid { get; set; }
        public string Servicetypename { get; set; }
        public decimal? Price { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
