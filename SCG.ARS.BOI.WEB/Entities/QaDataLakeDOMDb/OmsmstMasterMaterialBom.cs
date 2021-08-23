using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsmstMasterMaterialBom
    {
        public string Materialcode { get; set; }
        public int Bomno { get; set; }
        public string Childmatcode { get; set; }
        public decimal? Quantity { get; set; }
        public string Unit { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
