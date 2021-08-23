using System;
using System.Collections.Generic;

namespace SCG.ARS.BOI.WEB.Entities.MasterDb
{
    public partial class ArsTblCustomerTemplate
    {
        public int TemplateId { get; set; }
        public int CustomerId { get; set; }
        public int ReportId { get; set; }
    }
}
