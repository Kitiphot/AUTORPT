using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordServiceOrderSchedule
    {
        public long Id { get; set; }
        public string Sonumber { get; set; }
        public int Scheduleno { get; set; }
        public string Requesteddate { get; set; }
        public string Plandeliverydate { get; set; }
        public int Statuscode { get; set; }
        public string Remark { get; set; }
        public bool? Deleteflag { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Deliverycreatedate { get; set; }
        public bool? Transferdmflag { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
