using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordSapOrderItem
    {
        public string Orderno { get; set; }
        public string Itemno { get; set; }
        public string Materialcode { get; set; }
        public string Materialdesc { get; set; }
        public string Matfreightgroup { get; set; }
        public string Matfreightgroupdesc { get; set; }
        public string Shippingpoint { get; set; }
        public string Shippingpointdesc { get; set; }
        public string Shippingcondition { get; set; }
        public string Shippingconditiondesc { get; set; }
        public decimal? Orderqty { get; set; }
        public decimal? Confirmqty { get; set; }
        public decimal? Deliveryqty { get; set; }
        public string Saleunit { get; set; }
        public string Isosaleunit { get; set; }
        public decimal? Orderweight { get; set; }
        public decimal? Grossweight { get; set; }
        public decimal? Deliveryweight { get; set; }
        public string Weightunit { get; set; }
        public string Isoweightunit { get; set; }
        public decimal? Weightperunit { get; set; }
        public decimal? Weightperunitkg { get; set; }
        public decimal? Ordervolume { get; set; }
        public string Volumeunit { get; set; }
        public string Isovolumeunit { get; set; }
        public decimal? Volumeperunit { get; set; }
        public decimal? Volumeperunitccm { get; set; }
        public string Matavaildatetime { get; set; }
        public string Transportplaningdatetime { get; set; }
        public string Loadingdatetime { get; set; }
        public string Deliverydatetime { get; set; }
        public string Confirmdeldatetime { get; set; }
        public bool? Omsinactiveflag { get; set; }
        public bool? Omscancelflag { get; set; }
        public bool? Omshavescheduleflag { get; set; }
        public string Saproute { get; set; }
        public string Saproutedesc { get; set; }
        public decimal? Omstransittime { get; set; }
        public string Omsoriginlocationcode { get; set; }
        public string Omssystemremark { get; set; }
        public bool? Freegoodsflag { get; set; }
        public string Omscreateby { get; set; }
        public string Omscreatedate { get; set; }
        public string Omsupdateby { get; set; }
        public string Omsupdatedate { get; set; }
        public bool? Omsreqpalletflag { get; set; }
        public bool? Reqpalletflag { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
