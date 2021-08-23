using System;
using System.Collections.Generic;

namespace SCG.ARS.BOI.WEB.Entities.MasterDb
{
    public partial class ArsTblSchema
    {
        public int SchemaId { get; set; }
        public string SchemaName { get; set; }
        public string SchemaDisplay { get; set; }
        public string CatalogName { get; set; }
        public string SchemaOwner { get; set; }
        public string UpdateBy { get; set; }
        public string UpdateDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int SchemaOrder { get; set; }
    }
}
