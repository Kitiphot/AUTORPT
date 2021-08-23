using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmscitJobIntransitInfo
    {
        public string Loadid { get; set; }
        public string Dnnumber { get; set; }
        public string Deliverytype { get; set; }
        public string Customercode { get; set; }
        public string Customername { get; set; }
        public string Origincode { get; set; }
        public string Originname { get; set; }
        public string Destinationcode { get; set; }
        public string Destinationname { get; set; }
        public string Pickingdatetime { get; set; }
        public string Gidatetime { get; set; }
        public string Dnstatus { get; set; }
        public decimal Dnquantity { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
