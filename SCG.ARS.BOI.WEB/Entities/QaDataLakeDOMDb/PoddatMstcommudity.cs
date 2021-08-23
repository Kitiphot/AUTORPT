using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class PoddatMstcommudity
    {
        public string Commuditycode { get; set; }
        public string Commuditydesc { get; set; }
        public bool Ishazardous { get; set; }
        public string Commudityedi { get; set; }
        public decimal? Pickquantity { get; set; }
        public string Externalcode { get; set; }
        public string Referencetype { get; set; }
        public bool Isactive { get; set; }
        public Instant? Createddate { get; set; }
        public string Createduser { get; set; }
        public Instant? Changeddate { get; set; }
        public string Changeduser { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
