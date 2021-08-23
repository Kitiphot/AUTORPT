using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterBatchStatus
    {
        public string Batchtypecode { get; set; }
        public string Statuscode { get; set; }
        public string Statusdescription { get; set; }
        public string Remark { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
