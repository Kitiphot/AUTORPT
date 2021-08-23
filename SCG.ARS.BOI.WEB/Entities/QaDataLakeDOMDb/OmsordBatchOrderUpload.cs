using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordBatchOrderUpload
    {
        public long Id { get; set; }
        public string Customercode { get; set; }
        public int? Templateid { get; set; }
        public string Uploaddate { get; set; }
        public string Uploadby { get; set; }
        public bool? Inprocessflag { get; set; }
        public string Autosplitbatchno { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
