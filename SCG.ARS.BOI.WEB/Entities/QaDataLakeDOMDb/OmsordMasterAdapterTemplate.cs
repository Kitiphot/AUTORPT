using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterAdapterTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Orderpatternid { get; set; }
        public int? Ordertypeid { get; set; }
        public int? Customertypeid { get; set; }
        public int? FileHeaderrow { get; set; }
        public int? FileDatarow { get; set; }
        public string FileTemplatefields { get; set; }
        public string FileHeaderfields { get; set; }
        public string FileSheetname { get; set; }
        public bool? FileIsincludeheader { get; set; }
        public string FileType { get; set; }
        public int? Outsourceid { get; set; }
        public bool? Isactive { get; set; }
        public bool? Istransformtosap { get; set; }
        public string Transportmodecode { get; set; }
        public int? Pricingmodelid { get; set; }
        public string Createdby { get; set; }
        public string Createddate { get; set; }
        public string Updatedby { get; set; }
        public string Updateddate { get; set; }
        public string Warehouselocationcode { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
