using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class PoddatMstsaleorg
    {
        public string Saleorgcode { get; set; }
        public string Saleorgname { get; set; }
        public string Shortname { get; set; }
        public string Cosaleorg { get; set; }
        public string Addressno { get; set; }
        public string District { get; set; }
        public string Province { get; set; }
        public string Postalcode { get; set; }
        public string Transpzone { get; set; }
        public string Region { get; set; }
        public string Searchkey { get; set; }
        public string Searchterm { get; set; }
        public string Taxid { get; set; }
        public bool Isactive { get; set; }
        public Instant? Createddate { get; set; }
        public string Createduser { get; set; }
        public Instant? Changeddate { get; set; }
        public string Changeduser { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
