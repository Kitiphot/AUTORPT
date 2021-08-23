using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class OmsordMasterServiceModel
    {
        public int Id { get; set; }
        public string Transportserviceid { get; set; }
        public string Name { get; set; }
        public bool? IsValidateweight { get; set; }
        public decimal? Limitweight { get; set; }
        public bool? IsValidatedimension { get; set; }
        public decimal? Limitdimension { get; set; }
        public bool? IsValidatepostal { get; set; }
        public string Postalapi { get; set; }
        public bool IsActive { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
