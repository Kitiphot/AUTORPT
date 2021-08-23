using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Security.Model
{
    public class ApplicationRole : IdentityRole
    {
        public string Category { get; set; }
        [Required]
        [MaxLength(320)]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        [MaxLength(320)]
        public string UpdatedBy { get; set; }
        [Required]
        public DateTime UpdatedDate { get; set; }
        public ApplicationRole() { }
        public ApplicationRole(string roleName) :base(roleName) { }
    }
}
