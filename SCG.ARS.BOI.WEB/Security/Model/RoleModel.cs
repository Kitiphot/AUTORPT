using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Security.Model
{
    public class RoleModel
    {
        public string RoleID { get; set; }
        public string RoleName { get; set; }
        public string Category { get; set; }
        public List<string> AddUsers { get; set; }
        public List<string> DeleteUsers { get; set; }
    }
}
