using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmscitDeliverySapGoodIssue
    {
        public string Omsdnnumber { get; set; }
        public string Sapdnnumber { get; set; }
        public string Sourcesystem { get; set; }
        public string Idocnumber { get; set; }
        public string Pimessageid { get; set; }
        public int Sequence { get; set; }
        public string Serialization { get; set; }
        public string Sapdntype { get; set; }
        public string Sapsonumber { get; set; }
        public string Sappurchaseno { get; set; }
        public string Incoterm { get; set; }
        public string Shippingpoint { get; set; }
        public string Shipfromlocationcode { get; set; }
        public string Shipfromdescription { get; set; }
        public string Shiptolocationcode { get; set; }
        public string Shiptodescription { get; set; }
        public decimal? Totalvolume { get; set; }
        public decimal? Totalgrossweight { get; set; }
        public string Customercode { get; set; }
        public string Salesorg { get; set; }
        public string Deliverydate { get; set; }
        public string Sapdncreatedate { get; set; }
        public string Sapsocreatedate { get; set; }
        public string Sappickingdatetime { get; set; }
        public string Sapgidatetime { get; set; }
        public string Sappickingstatus { get; set; }
        public string Sapgistatus { get; set; }
        public string Sapsopaymentterm { get; set; }
        public string Sapsoreqdlvdate { get; set; }
        public string Dmreceivertel { get; set; }
        public string Dmscheduledate { get; set; }
        public bool Deleteflag { get; set; }
        public string Remark { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool Backdateflag { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
