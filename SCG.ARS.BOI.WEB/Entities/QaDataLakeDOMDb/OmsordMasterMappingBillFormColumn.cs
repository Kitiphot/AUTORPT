using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterMappingBillFormColumn
    {
        public int Formid { get; set; }
        public string Fieldname { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
