using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordDeliveryHeaderServiceOptions
    {
        public string Dnnumber { get; set; }
        public string Legheader { get; set; }
        public string Refdnnumber { get; set; }
        public int Serviceitemid { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Deliverytype { get; set; }
        public bool Deleteflag { get; set; }
        public string Otherdescription { get; set; }
        public decimal? Price { get; set; }
        public string Sonumber { get; set; }
        public string Serviceitemname { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
