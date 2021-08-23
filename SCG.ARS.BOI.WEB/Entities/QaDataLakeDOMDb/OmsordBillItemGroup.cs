using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordBillItemGroup
    {
        public long Billid { get; set; }
        public string Matfreightgroup { get; set; }
        public string Matfreightgroupdesc { get; set; }
        public string Itemtext { get; set; }
        public decimal Amount { get; set; }
        public bool Deleteflag { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
