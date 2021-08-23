using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class PoddatUserdevice
    {
        public string Deviceid { get; set; }
        public string Username { get; set; }
        public string Usertype { get; set; }
        public string Usercode { get; set; }
        public Instant Createddate { get; set; }
        public string Createduser { get; set; }
        public Instant? Changeddate { get; set; }
        public string Changeduser { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
