using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordServiceOrder
    {
        public string Sonumber { get; set; }
        public int Orderpatternid { get; set; }
        public string Customercode { get; set; }
        public string Customername1 { get; set; }
        public string Customername2 { get; set; }
        public string Customername3 { get; set; }
        public string Customername4 { get; set; }
        public string Customerstreet { get; set; }
        public string Customerdistrict { get; set; }
        public string Customercity { get; set; }
        public string Customerpostalcode { get; set; }
        public string Customertype { get; set; }
        public string Ponumber { get; set; }
        public int Statuscode { get; set; }
        public string Paymentterm { get; set; }
        public string Orderdate { get; set; }
        public string Remark { get; set; }
        public long? Batchid { get; set; }
        public string Draftreason { get; set; }
        public bool Ordercharge { get; set; }
        public string Creditgroup { get; set; }
        public string Creditfidocid { get; set; }
        public decimal? Creditamount { get; set; }
        public bool? Creditapprovedflag { get; set; }
        public string Creditapproveddate { get; set; }
        public bool? Deleteflag { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool Autoreleaseflag { get; set; }
        public int Billingstatus { get; set; }
        public int? Creditdocfiscalyear { get; set; }
        public string Warningmessage { get; set; }
        public string Billgroupname { get; set; }
        public string Reference1 { get; set; }
        public string Reference2 { get; set; }
        public string Reference3 { get; set; }
        public string Reference4 { get; set; }
        public string Reference5 { get; set; }
        public decimal? Creditapprovedamount { get; set; }
        public bool? Haveshippingmark { get; set; }
        public bool? Isusestandardcuttingtime { get; set; }
        public string Mergeintransitcode { get; set; }
        public string Sourcesystem { get; set; }
        public string Idocno { get; set; }
        public string Omscarriercode { get; set; }
        public string Omsdriverlicenseno { get; set; }
        public string Omsequipmenttype { get; set; }
        public string Omsmergeintransitcode { get; set; }
        public string Omsposervice { get; set; }
        public bool? Omsprebuildloadflag { get; set; }
        public bool? Omsreqpalletflag { get; set; }
        public string Omsservicetype { get; set; }
        public string Omsshipmentmemo { get; set; }
        public string Omsspecialordertype { get; set; }
        public decimal? Omsspotrate { get; set; }
        public string Omsspotunit { get; set; }
        public string Omstrailerlicenseno { get; set; }
        public string Omsvesselname { get; set; }
        public string Orderdeliverycreatedate { get; set; }
        public string Payercode { get; set; }
        public string Payername { get; set; }
        public string Refdistrchan { get; set; }
        public string Refdivision { get; set; }
        public string Refincoterm { get; set; }
        public string Refordertype { get; set; }
        public string Refsaleorg { get; set; }
        public string Requestdeliverydate { get; set; }
        public bool? Agentflag { get; set; }
        public string Refsalesdoctype { get; set; }
        public string Refrequestdeliverydate { get; set; }
        public bool? Completedeliveryflag { get; set; }
        public string Dmreceivertelephone { get; set; }
        public string Dmscheduledate { get; set; }
        public string Sapshiptoname { get; set; }
        public string Soldtoregion { get; set; }
        public string Soldtotelephone { get; set; }
        public bool? Issapgiadvance { get; set; }
        public string Payercompanycode { get; set; }
        public string Creditapprovedate { get; set; }
        public string Recipiantname { get; set; }
        public string Recipianttelephone { get; set; }
        public string Specialcondition { get; set; }
        public bool? Isscheduling { get; set; }
        public bool? Issoldtoready { get; set; }
        public string Refincoterm2 { get; set; }
        public string Refincoterm3 { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
