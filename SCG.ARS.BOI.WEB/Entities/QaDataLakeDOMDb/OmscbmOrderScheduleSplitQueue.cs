using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmscbmOrderScheduleSplitQueue
    {
        public string Orderno { get; set; }
        public string Orderline { get; set; }
        public long? Booknumber { get; set; }
        public string Matfreightgroupcode { get; set; }
        public decimal Scheduleweight { get; set; }
        public string Scheduleweightunit { get; set; }
        public string Plannerusername { get; set; }
        public string Status { get; set; }
        public bool Activeflag { get; set; }
        public string Createddate { get; set; }
        public string Createdby { get; set; }
        public string Updateddate { get; set; }
        public string Updatedby { get; set; }
        public string Requesteddate { get; set; }
        public string Autosplitbatchno { get; set; }
        public string Autospliterrormessage { get; set; }
        public bool Compensatedflag { get; set; }
        public string Soldtocode { get; set; }
        public string Shiptotranzone { get; set; }
        public bool Smalllotflag { get; set; }
        public string Shiptocode { get; set; }
        public bool Combineflag { get; set; }
        public byte[] Rowversion { get; set; }
        public bool Completeschedulelineflag { get; set; }
        public bool Bypassflag { get; set; }
        public Instant? DmsRepDtt { get; set; }
        public string Calculationtype { get; set; }
        public bool? Waitingtocombineflag { get; set; }
        public bool? Fieldflag { get; set; }
        public int? Systemid { get; set; }
    }
}
