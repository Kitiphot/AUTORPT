using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmscitDeliveryHeaderServiceOptions
    {
        public string Dnnumber { get; set; }
        public string Legheader { get; set; }
        public int Legid { get; set; }
        public string Refdnnumber { get; set; }
        public long Orderscheduleline { get; set; }
        public int Orderschedulelineno { get; set; }
        public int Serviceoptionseq { get; set; }
        public string Serviceoptionname { get; set; }
        public string Serviceoptionvalue { get; set; }
        public string Serviceoptionremark { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
