using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmscbmMasterFleetShippointMatfreight
    {
        public int Fleetid { get; set; }
        public string Shippingpointcode { get; set; }
        public string Matfreightgroupcode { get; set; }
        public decimal Minweight { get; set; }
        public decimal Maxweight { get; set; }
        public string Shiptoregion { get; set; }
        public string Plannerusername { get; set; }
        public string Createddate { get; set; }
        public string Createdby { get; set; }
        public string Updateddate { get; set; }
        public string Updatedby { get; set; }
        public int Id { get; set; }
        public string Shipcondcode { get; set; }
        public Instant? DmsRepDtt { get; set; }
        public int? Systemid { get; set; }
    }
}
