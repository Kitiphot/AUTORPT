using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class PoddatDamageheader
    {
        public string Documentno { get; set; }
        public string Manager { get; set; }
        public string Department { get; set; }
        public Instant Createddate { get; set; }
        public string Createduser { get; set; }
        public string Damagestatus { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
