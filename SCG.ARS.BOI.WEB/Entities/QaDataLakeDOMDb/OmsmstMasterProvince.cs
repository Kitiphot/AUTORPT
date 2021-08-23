using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsmstMasterProvince
    {
        public string Provincecode { get; set; }
        public string Provincename { get; set; }
        public bool Deleteflag { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public int Regioncode { get; set; }
        public string Sapcode { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
