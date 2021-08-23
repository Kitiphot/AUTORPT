using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Security.Model
{
    public class ScreenModel
    {
        public int MenuID { get; set; }
        public int? ParentID { get; set; }
        public string MenuCode { get; set; }
        public string MenuName { get; set; }
        public string MenuRoute { get; set; }
        public string MenuPath { get; set; }
        public string OrderPath { get; set; }
        public string MenuIcon { get; set; }
        public int Order { get; set; }
        public int Depth { get; set; }
        public bool Allow { get; set; }
        public string Permission { get; set; }
    }
    public class ScreenPermissionModel
    {
        public int MenuID { get; set; }
        public string Permission { get; set; }
    }
}
