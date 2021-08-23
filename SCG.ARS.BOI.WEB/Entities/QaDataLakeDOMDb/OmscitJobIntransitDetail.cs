using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmscitJobIntransitDetail
    {
        public int Jobdetailid { get; set; }
        public int Jobheaderid { get; set; }
        public string Loadid { get; set; }
        public string Carriercode { get; set; }
        public string Carriername { get; set; }
        public string Origincode { get; set; }
        public string Originname { get; set; }
        public string Destinationcode { get; set; }
        public string Destinationname { get; set; }
        public string Accepttenderdatetime { get; set; }
        public string Intransitdatetime { get; set; }
        public string Loadstatus { get; set; }
        public decimal Totalquantity { get; set; }
        public decimal Differencequantity { get; set; }
        public string Jobmessage { get; set; }
        public string Jobstatus { get; set; }
        public string Joberrormessage { get; set; }
        public string Tmspimessageid { get; set; }
        public string Sapidocnumber { get; set; }
        public bool? Retrieveflag { get; set; }
        public string Retrievedatetime { get; set; }
        public string Retrivepimessageid { get; set; }
        public bool? Unsuspendflag { get; set; }
        public string Unsuspenddatetime { get; set; }
        public string Unsuspendpimessageid { get; set; }
        public bool? Confirmflag { get; set; }
        public string Confirmdatetime { get; set; }
        public string Confirmpimessageid { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Loadsequencenumber { get; set; }
        public string Tripid { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
