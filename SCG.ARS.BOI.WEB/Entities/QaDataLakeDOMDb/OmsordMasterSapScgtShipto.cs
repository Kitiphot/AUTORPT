using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterSapScgtShipto
    {
        public string Scgtshiptocode { get; set; }
        public string Scgtshiptoname { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
