using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Models.Generwiz
{
    public class OrderPendingDetailModel
    {
        public string ponumber { get; set; }
        public string customercode { get; set; }
        public string customername { get; set; }
        public string sapshippingpoint { get; set; }
        public string sapshiptocode { get; set; }
        public string destinationname { get; set; }
        public string destinationcode { get; set; }
        public string shiptoregioncode { get; set; }
        public string shiptoregionname { get; set; }
        public string materialcode { get; set; }
        public string materialname { get; set; }
        public string shiptoaddress { get; set; }
        public string shiptocity { get; set; }
        public string dnnumber { get; set; }
        public string shipmentloadid { get; set; }
        public string orderdoctype { get; set; }
        public string origincode { get; set; }
        public string originname { get; set; }
        public string originregion { get; set; }
        public DateTime actual_tender { get; set; }
        public string requesteddate { get; set; }
        public string orderdate { get; set; }
        public string materialfreightgroup { get; set; }
        public string materialfreightdescription { get; set; }
        public string sonumber { get; set; }
        public string shippingcondition { get; set; }
        public string shippingconditiondescription { get; set; }
        public decimal totalnetweight { get; set; }
        public string orderline { get; set; }
        public string vehicletypecode { get; set; }
        public string vehicletypename { get; set; }
        public string shipmentmemo { get; set; }
        public string carriercode { get; set; }
        public string carriername { get; set; }
        public string status { get; set; }
        public string booknumber { get; set; }
        public string dnnanme { get; set; }
        public string loadstatus { get; set; }
        public string plannername { get; set; }
        public string provincecode { get; set; }
        public string zone { get; set; }
    }
}
