using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class PoddatMstdriver
    {
        public string Citizenid { get; set; }
        public string Carriercode { get; set; }
        public string Nametitle { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Fullname { get; set; }
        public string Telephone { get; set; }
        public string Drivertype { get; set; }
        public string Acceptstatus { get; set; }
        public string Trucklicense { get; set; }
        public string Provinceid { get; set; }
        public string Provincename { get; set; }
        public string Shortprovince { get; set; }
        public string Fullplate { get; set; }
        public string Email { get; set; }
        public string Expiredate { get; set; }
        public Instant? Createddate { get; set; }
        public string Createduser { get; set; }
        public Instant? Changeddate { get; set; }
        public string Changeduser { get; set; }
        public bool Isactive { get; set; }
        public int? Jobcomplete { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
