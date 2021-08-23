using System;
using System.Collections.Generic;
using NodaTime;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakeDOMDb
{
    public partial class ScvcorMasterSalesOrg
    {
        public string SalesOrg { get; set; }
        public string Description { get; set; }
        public bool? InactiveFlag { get; set; }
        public string UserCreateName { get; set; }
        public Instant? UserCreateDate { get; set; }
        public string UserUpdateName { get; set; }
        public Instant? UserUpdateDate { get; set; }
        public Instant? DmsRepDtt { get; set; }
    }
}
