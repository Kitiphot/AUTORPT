using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordServiceOrderDetailOutsource
    {
        public int Id { get; set; }
        public string Sonumber { get; set; }
        public string Fieldname { get; set; }
        public string Fieldvalue { get; set; }
        public string Fielddescription { get; set; }
        public string Fieldtype { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
