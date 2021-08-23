using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordSapOrderAutosplittingCriteria
    {
        public string Sapbatchno { get; set; }
        public string Orderno { get; set; }
        public string Orderline { get; set; }
        public string Userposition { get; set; }
        public string Documenttype { get; set; }
        public string Orderstatus { get; set; }
        public string Projectmanagerorder { get; set; }
        public string Ordernumberfrom { get; set; }
        public string Ordernumberto { get; set; }
        public string Deliverycreatedatefrom { get; set; }
        public string Deliverycreatedateto { get; set; }
        public string DeliverycreatedatefromStr { get; set; }
        public string DeliverycreatedatetoStr { get; set; }
        public string Requestdeliverydatefrom { get; set; }
        public string Requestdeliverydateto { get; set; }
        public string RequestdeliverydatefromStr { get; set; }
        public string RequestdeliverydatetoStr { get; set; }
        public string Ordercreatedatefrom { get; set; }
        public string Ordercreatedateto { get; set; }
        public string OrdercreatedatefromStr { get; set; }
        public string OrdercreatedatetoStr { get; set; }
        public string Incoterm1from { get; set; }
        public string Incoterm1to { get; set; }
        public decimal? Availableweightorderfrom { get; set; }
        public decimal? Availableweightorderto { get; set; }
        public string Availableweightorderunit { get; set; }
        public string Soldtopartyfrom { get; set; }
        public string Soldtopartyto { get; set; }
        public string Soldtopartypostalcodefrom { get; set; }
        public string Soldtopartypostalcodeto { get; set; }
        public string Shiptopartyfrom { get; set; }
        public string Shiptopartyto { get; set; }
        public decimal? Availablevolumeorderfrom { get; set; }
        public decimal? Availablevolumeorderto { get; set; }
        public string Availablevolumeorderunit { get; set; }
        public int? Numberofdays { get; set; }
        public string Regionlevel { get; set; }
        public string Shiptoregiontype { get; set; }
        public string Shiptosapregionfrom { get; set; }
        public string Shiptosapregionto { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
