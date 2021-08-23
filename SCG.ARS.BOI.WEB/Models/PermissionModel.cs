using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Models
{
    public class PermissionModel
    {
        public int usergroup_id { get; set; }
        public int menu_id { get; set; }
        public string menu_code { get; set; }
        public string menu_name { get; set; }
        public int fullcontrol_flag { get; set; }
        public int readonly_flag { get; set; }
    }
}
