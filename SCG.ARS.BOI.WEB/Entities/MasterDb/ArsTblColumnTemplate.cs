using System;
using System.Collections.Generic;

namespace SCG.ARS.BOI.WEB.Entities.MasterDb
{
    public partial class ArsTblColumnTemplate
    {
        public int TemplateId { get; set; }
        public int ColumnId { get; set; }
        public string ColumnName { get; set; }
        public int? ColumnTypeId { get; set; }
    }
}
