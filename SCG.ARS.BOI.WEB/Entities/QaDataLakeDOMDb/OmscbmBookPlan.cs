using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmscbmBookPlan
    {
        public string Oldbooknumber { get; set; }
        public int Fleetid { get; set; }
        public string Fleetname { get; set; }
        public string Bookeddate { get; set; }
        public string Vehicletypecode { get; set; }
        public string Vehicletypename { get; set; }
        public decimal Vehiclecapweight { get; set; }
        public string Vehicleweightunit { get; set; }
        public int Bookedamount { get; set; }
        public bool Activeflag { get; set; }
        public string Createddate { get; set; }
        public string Createdby { get; set; }
        public string Updateddate { get; set; }
        public string Updatedby { get; set; }
        public long Booknumber { get; set; }
        public int? Bookqueue { get; set; }
        public string Booktype { get; set; }
        public string Queuedate { get; set; }
        public byte[] Rowversion { get; set; }
        public bool Waitingflag { get; set; }
        public bool Pendingapproveflag { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
