using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmscbmMasterSaleArea
    {
        public int Saleareagroupid { get; set; }
        public int Bugroupid { get; set; }
        public string Saleorgcode { get; set; }
        public string Distrchancode { get; set; }
        public string Divisioncode { get; set; }
        public string Salesofficecode { get; set; }
        public bool Activeflag { get; set; }
        public string Createddate { get; set; }
        public string Createdby { get; set; }
        public string Updateddate { get; set; }
        public string Updatedby { get; set; }
        public int Systemid { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
