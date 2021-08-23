using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordDeliveryItemsGoodReceive
    {
        public string Refdnnumber { get; set; }
        public int Dnitem { get; set; }
        public string Sonumber { get; set; }
        public int Soitemnumber { get; set; }
        public int Legid { get; set; }
        public string Customercode { get; set; }
        public string Transactionid { get; set; }
        public string Materialcode { get; set; }
        public string Materialfreightgroup { get; set; }
        public decimal? Materialnetweight { get; set; }
        public decimal? Materialgrossweight { get; set; }
        public decimal? Materialvolume { get; set; }
        public string Materialbaseunit { get; set; }
        public decimal Quantity { get; set; }
        public decimal? Totalnetweight { get; set; }
        public decimal? Totalgrossweight { get; set; }
        public string Weightunit { get; set; }
        public decimal? Totalvolume { get; set; }
        public string Volumeunit { get; set; }
        public bool Deleteflag { get; set; }
        public string Remark { get; set; }
        public string Sourcesystem { get; set; }
        public string Plannername { get; set; }
        public string Reason { get; set; }
        public bool Completedflag { get; set; }
        public string Issuedatetime { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Deliverytype { get; set; }
        public string Stampdatetime { get; set; }
        public decimal Breakitemquantity { get; set; }
        public decimal Gooditemquantity { get; set; }
        public decimal Missitemquantity { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
