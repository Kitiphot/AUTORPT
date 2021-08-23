using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class PoddatTruckcommit
    {
        public string Carriercode { get; set; }
        public string Fleetcode { get; set; }
        public string Trucktypecode { get; set; }
        public string Commuditycode { get; set; }
        public string Zonecode { get; set; }
        public string Commitdate { get; set; }
        public int Commitamount { get; set; }
        public Instant? Createddate { get; set; }
        public string Createduser { get; set; }
        public int? Entityid { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
