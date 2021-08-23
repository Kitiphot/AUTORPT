using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmscbmMasterVehicleType
    {
        public string Vehicletypecode { get; set; }
        public string Vehicletypename { get; set; }
        public decimal Minweight { get; set; }
        public decimal Capweight { get; set; }
        public decimal? Utilityweight { get; set; }
        public string Capweightunit { get; set; }
        public decimal Capvolume { get; set; }
        public string Capvolumeunit { get; set; }
        public bool Schedulingflag { get; set; }
        public bool Deleteflag { get; set; }
        public string Createddate { get; set; }
        public string Createdby { get; set; }
        public string Updateddate { get; set; }
        public string Updatedby { get; set; }
        public decimal? Buildmatcapweight { get; set; }
        public bool Buildmatflag { get; set; }
        public decimal? Buildmatminweight { get; set; }
        public string Buildmatunit { get; set; }
        public string Shipcondcode { get; set; }
        public Instant? DmsRepDtt { get; set; }
        public decimal? Expectweight { get; set; }
        public decimal? Overvolumn { get; set; }
    }
}
