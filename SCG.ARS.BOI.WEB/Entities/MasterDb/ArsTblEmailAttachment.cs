using System;
using System.Collections.Generic;

namespace SCG.ARS.BOI.WEB.Entities.MasterDb
{
    public partial class ArsTblEmailAttachment
    {
        public long EmailAttachmentId { get; set; }
        public int EmailSchedulerId { get; set; }
        public int TemplateReportMappingId { get; set; }
    }
}
