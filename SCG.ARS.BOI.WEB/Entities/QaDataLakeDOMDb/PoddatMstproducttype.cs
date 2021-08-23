using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class PoddatMstproducttype
    {
        public string Productcode { get; set; }
        public string Productname { get; set; }
        public Instant? Createddate { get; set; }
        public string Createduser { get; set; }
        public Instant? Changeddate { get; set; }
        public string Changeduser { get; set; }
        public bool Isactive { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
