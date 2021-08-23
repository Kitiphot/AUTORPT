using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsmstMasterEndCustomer
    {
        public long Id { get; set; }
        public string Endcustomercode { get; set; }
        public string Customercode { get; set; }
        public string Endcustomername { get; set; }
        public string Address { get; set; }
        public string Locationcode { get; set; }
        public string Sapshiptocode { get; set; }
        public string Lono { get; set; }
        public bool Deleteflag { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Sapshiptotype { get; set; }
        public string Customertransportmode { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
