using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class PoddatMstcarrier
    {
        public string Carriercode { get; set; }
        public string Carriername { get; set; }
        public string Addressno { get; set; }
        public string Addresscity { get; set; }
        public string Regioncode { get; set; }
        public string Emailaddress { get; set; }
        public Instant? Createddate { get; set; }
        public string Createduser { get; set; }
        public Instant? Changeddate { get; set; }
        public string Changeduser { get; set; }
        public bool Isactive { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
