using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsmstMasterSapAmphur
    {
        public string Amphurcode { get; set; }
        public string Amphurname { get; set; }
        public bool? Deleteflag { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
