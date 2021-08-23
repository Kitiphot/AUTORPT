﻿using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordDeliveryHeader
    {
        public string Dnnumber { get; set; }
        public string Legheader { get; set; }
        public int Legid { get; set; }
        public long Orderscheduleline { get; set; }
        public int Orderschedulelineno { get; set; }
        public string Refdnnumber { get; set; }
        public string Shipmentnumber { get; set; }
        public string Shipmentloadid { get; set; }
        public string Sourcesystem { get; set; }
        public string Systembatchno { get; set; }
        public string Sonumber { get; set; }
        public string Orderdoctype { get; set; }
        public string Ponumber { get; set; }
        public int Orderpatternid { get; set; }
        public string Customercode { get; set; }
        public string Customername { get; set; }
        public string Origincode { get; set; }
        public string Originname { get; set; }
        public string Originlocationtype { get; set; }
        public string Destinationcode { get; set; }
        public string Destinationname { get; set; }
        public string Destinationlocationtype { get; set; }
        public string Shiptocode { get; set; }
        public string Shiptoname { get; set; }
        public string Endcustomercode { get; set; }
        public string Endcustomername { get; set; }
        public string Servicelevel { get; set; }
        public string Serviceleveldescription { get; set; }
        public string Orderdate { get; set; }
        public string Requesteddate { get; set; }
        public string Planeddeliverydate { get; set; }
        public string Pickedupfromdate { get; set; }
        public string Pickeduptodate { get; set; }
        public string Deliveredfromdate { get; set; }
        public string Deliveredtodate { get; set; }
        public string Vehicletypeid { get; set; }
        public string Warehouseloccode { get; set; }
        public string Outsource { get; set; }
        public bool Biglot { get; set; }
        public string Deliverytype { get; set; }
        public string Equipmenttype { get; set; }
        public string Carriercode { get; set; }
        public string Servicetype { get; set; }
        public string Mergeintransitcode { get; set; }
        public string Transportmode { get; set; }
        public string Specialordertype { get; set; }
        public string Vesselname { get; set; }
        public string Driverlicenseno { get; set; }
        public string Trailerlicenseno { get; set; }
        public string Incotermcode { get; set; }
        public string Incotermdescription { get; set; }
        public decimal? Spotrate { get; set; }
        public string Spotunit { get; set; }
        public string Plannername { get; set; }
        public string Remark { get; set; }
        public string Shipmentmemo { get; set; }
        public int Retryno { get; set; }
        public bool Requirepalletflag { get; set; }
        public bool Isexecutejobschedule { get; set; }
        public bool Isprebuildload { get; set; }
        public bool Isoverridethoughpoint { get; set; }
        public bool Isoverwritecharge { get; set; }
        public bool Receivedflag { get; set; }
        public bool Returnflag { get; set; }
        public bool Deleteflag { get; set; }
        public int Statuscode { get; set; }
        public string Errormessage { get; set; }
        public bool? Iscreateshipment { get; set; }
        public bool Issuspendload { get; set; }
        public string Batchupdatedate { get; set; }
        public string Shipmentprocessdatetime { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Shiptotype { get; set; }
        public bool? Iscompletedgi { get; set; }
        public string Shiptospecialcond { get; set; }
        public string Shipfromcode { get; set; }
        public string Shipfromname { get; set; }
        public string Shipfromtype { get; set; }
        public string Delivereddatetime { get; set; }
        public string Gicompleteddatetime { get; set; }
        public string Docreturndatetime { get; set; }
        public string Shipmentlegid { get; set; }
        public string Giheadertext { get; set; }
        public string Grcompleteddatetime { get; set; }
        public bool? Iscompletedgr { get; set; }
        public bool? Iscompletedpackedflag { get; set; }
        public bool Requirepackflag { get; set; }
        public string Omsrouteid { get; set; }
        public string Giremark { get; set; }
        public string Grremark { get; set; }
        public string Licenseplate { get; set; }
        public string Freightclasscode { get; set; }
        public bool? Haveshippingmark { get; set; }
        public bool? Isconfirmdndist { get; set; }
        public string Sapshippingpoint { get; set; }
        public string Sapshipto { get; set; }
        public string SoIdocno { get; set; }
        public bool Refblockdndist { get; set; }
        public bool Refwaitdnsap { get; set; }
        public bool Iscreatednsap { get; set; }
        public string Customercity { get; set; }
        public string Customerdistrict { get; set; }
        public string Customerpostalcode { get; set; }
        public string Customerstreet { get; set; }
        public string Dmreceivertelephone { get; set; }
        public string Dmscheduledate { get; set; }
        public string Paymentterm { get; set; }
        public string Refsaleorg { get; set; }
        public string Sapshiptoname { get; set; }
        public string Shiptotelephone { get; set; }
        public string Soldtoregion { get; set; }
        public string Soldtotelephone { get; set; }
        public bool Issapgiadvance { get; set; }
        public string Sapshipmentnumber { get; set; }
        public string Incotermcode2 { get; set; }
        public string Incotermcode3 { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
