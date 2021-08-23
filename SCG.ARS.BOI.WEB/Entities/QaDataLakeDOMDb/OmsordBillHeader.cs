using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordBillHeader
    {
        public long Id { get; set; }
        public string Billnumber { get; set; }
        public string Customercode { get; set; }
        public string Servicecode { get; set; }
        public string Invoicecreationdate { get; set; }
        public string Postingdate { get; set; }
        public string Baselinedate { get; set; }
        public string Currency { get; set; }
        public decimal? Vatamount { get; set; }
        public string Taxcode { get; set; }
        public string Paymentterm { get; set; }
        public string Channel { get; set; }
        public string Postsapstatus { get; set; }
        public string Saperrormessage { get; set; }
        public string Sapfidocno { get; set; }
        public string Sapfiscalyear { get; set; }
        public string Refsapfidocno { get; set; }
        public string Refsapfiscalyear { get; set; }
        public string Approvedby { get; set; }
        public string Approveddate { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Periodto { get; set; }
        public string Sappaymentdate { get; set; }
        public string Sappaymentdocno { get; set; }
        public bool Isreposted { get; set; }
        public bool Isprinted { get; set; }
        public string Billgroupname { get; set; }
        public string Transportmode { get; set; }
        public string Periodfrom { get; set; }
        public int? Billingdate { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
