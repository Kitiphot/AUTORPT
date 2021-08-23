using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterBatchType
    {
        public string Batchtypecode { get; set; }
        public string Batchtypename { get; set; }
        public bool Inactiveflag { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
