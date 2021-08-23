using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterBillFormColumn
    {
        public string Columnnameth { get; set; }
        public string Columnnameen { get; set; }
        public string Fieldname { get; set; }
        public int? Order { get; set; }
        public string Columnstyle { get; set; }
        public bool? Isformatnumber { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
