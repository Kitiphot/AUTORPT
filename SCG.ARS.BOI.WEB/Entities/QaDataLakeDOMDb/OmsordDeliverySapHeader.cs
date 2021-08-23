using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordDeliverySapHeader
    {
        public string Dnnumber { get; set; }
        public string Legheader { get; set; }
        public int Legid { get; set; }
        public string Refdnnumber { get; set; }
        public string Sourcesystem { get; set; }
        public string Orderscheduleline { get; set; }
        public string Ponumber { get; set; }
        public string Omsposervice { get; set; }
        public string Customercode { get; set; }
        public string Customername { get; set; }
        public string Sonumber { get; set; }
        public string Orderdoctype { get; set; }
        public string Systembatchno { get; set; }
        public string Sapbatchno { get; set; }
        public string Vehicletypeid { get; set; }
        public string Warehouseloccode { get; set; }
        public int Stocktypecode { get; set; }
        public string Stocktypedesc { get; set; }
        public string Outsource { get; set; }
        public string Orderdate { get; set; }
        public string Requesteddate { get; set; }
        public string Planeddeliverydate { get; set; }
        public string Deliverytype { get; set; }
        public bool Biglot { get; set; }
        public string Newdeliverydatefrom { get; set; }
        public string Newdeliverydateto { get; set; }
        public string Sapshippingpoint { get; set; }
        public string Sapshippingpointdescription { get; set; }
        public string Origincode { get; set; }
        public string Originname { get; set; }
        public string Originlocationtype { get; set; }
        public string Sapshiptocode { get; set; }
        public string Sapshiptoname { get; set; }
        public string Destinationcode { get; set; }
        public string Destinationname { get; set; }
        public string Destinationlocationtype { get; set; }
        public string Shipmentmemo { get; set; }
        public string Pickedupfromdate { get; set; }
        public string Pickeduptodate { get; set; }
        public string Deliveredfromdate { get; set; }
        public string Deliveredtodate { get; set; }
        public string Saproute { get; set; }
        public string Servicelevel { get; set; }
        public string Serviceleveldescription { get; set; }
        public bool Isprebuildload { get; set; }
        public string Equipmenttype { get; set; }
        public string Carriercode { get; set; }
        public string Servicetype { get; set; }
        public string Mergeintransitcode { get; set; }
        public string Shiptocode { get; set; }
        public string Shiptoaddress { get; set; }
        public string Shiptocity { get; set; }
        public string Shiptopostalcode { get; set; }
        public string Shiptoregioncode { get; set; }
        public string Shiptoregionname { get; set; }
        public string Shiptorecipientname { get; set; }
        public string Shiptotelephone { get; set; }
        public string Shiptomobile { get; set; }
        public string Shiptospecialcondition { get; set; }
        public decimal? Spotrate { get; set; }
        public string Spotunit { get; set; }
        public string Trailerlicenseno { get; set; }
        public string Driverlicenseno { get; set; }
        public string Transportmode { get; set; }
        public string Plannername { get; set; }
        public bool Isexecuteinjobschedule { get; set; }
        public bool Isoverwritethoughpoint { get; set; }
        public bool Isoverwritecharge { get; set; }
        public bool? Issenttosap { get; set; }
        public bool? Isrecievefromsap { get; set; }
        public string Saperrormessage { get; set; }
        public bool? Iscreatedshipment { get; set; }
        public bool Islastmile { get; set; }
        public string Shipmenterrormessage { get; set; }
        public string Batchupdateddate { get; set; }
        public string Shipmentprocessdatetime { get; set; }
        public string Specialordertype { get; set; }
        public string Vesselname { get; set; }
        public string Incotermcode { get; set; }
        public string Incotermdescription { get; set; }
        public int Requestdncount { get; set; }
        public int Retryno { get; set; }
        public int Statuscode { get; set; }
        public string Errormessage { get; set; }
        public bool Requirepalletflag { get; set; }
        public bool Returnflag { get; set; }
        public bool Deleteflag { get; set; }
        public bool Cancelflag { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Shiptoname { get; set; }
        public string Shipmentloadid { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
