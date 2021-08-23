using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class PoddatAbnormality
    {
        public int Caseno { get; set; }
        public string Trucklicense { get; set; }
        public string Driverlecense { get; set; }
        public string Reasoncode { get; set; }
        public string Remarktext { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public Instant? Createddate { get; set; }
        public string Createduser { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
