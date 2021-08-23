using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterRoute
    {
        public string Id { get; set; }
        public string Originlocid { get; set; }
        public string Destlocid { get; set; }
        public string Hublocid { get; set; }
        public int Originloctype { get; set; }
        public int Destloctype { get; set; }
        public string Routemodel { get; set; }
        public int Priority { get; set; }
        public decimal Percentftlweight { get; set; }
        public bool IsActive { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
