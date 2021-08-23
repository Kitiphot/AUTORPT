using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Security.Model
{
    public class PermissionModel
    {
        public string Key { get; set; }
        public List<PermissionClaimModel> Permissions { get; set; }
    }

    public class PermissionClaimModel
    {
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public int IsAllow { get; set; }
    }
}
