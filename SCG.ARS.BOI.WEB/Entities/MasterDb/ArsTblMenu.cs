using System;
using System.Collections.Generic;

namespace SCG.ARS.BOI.WEB.Entities.MasterDb
{
    public partial class ArsTblMenu
    {
        public int MenuId { get; set; }
        public int? ParentId { get; set; }
        public string MenuCode { get; set; }
        public string MenuName { get; set; }
        public string MenuIcon { get; set; }
        public string MenuPath { get; set; }
        public bool? IsActive { get; set; }
        public string MenuPage { get; set; }
        public int MenuOrder { get; set; }
    }
}
