using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class PoddatPhototaking
    {
        public string Groupcode { get; set; }
        public string Photocode { get; set; }
        public string Photodesc { get; set; }
        public Instant? Createddate { get; set; }
        public string Createduser { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
