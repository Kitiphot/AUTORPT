using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordTmsShipment
    {
        public string Shipmentnumber { get; set; }
        public string Shipmentsequencenumber { get; set; }
        public string Systemshipmentid { get; set; }
        public string Systemshipmentloadid { get; set; }
        public string Systemshipmentlegid { get; set; }
        public decimal Totaldistance { get; set; }
        public string Createdshipmentdate { get; set; }
        public string Tenderedupdateddate { get; set; }
        public string Accepttenderedupdateddate { get; set; }
        public string Intransitupdateddate { get; set; }
        public string Loadcompletedupdateddate { get; set; }
        public bool Onholdflag { get; set; }
        public bool Suspendedflag { get; set; }
        public string Suspendedreason { get; set; }
        public string Currentshipmentopstatus { get; set; }
        public string Currentshipmentopstatusdescription { get; set; }
        public string Equipmenttype { get; set; }
        public string Systemstopid { get; set; }
        public int Stopsequencenumber { get; set; }
        public string Stoplocationcode { get; set; }
        public string Stopshippingpointtype { get; set; }
        public bool Deleteflag { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public int Omslegid { get; set; }
        public int Shipmentitineraryseqnum { get; set; }
        public Instant? DmsRepDtt { get; set; }
        public string Sapshipmentnumber { get; set; }
    }
}
