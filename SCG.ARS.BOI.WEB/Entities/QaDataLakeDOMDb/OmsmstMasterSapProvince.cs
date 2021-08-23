using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsmstMasterSapProvince
    {
        public string Provincecode { get; set; }
        public string Provincename { get; set; }
        public bool? Deleteflag { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
