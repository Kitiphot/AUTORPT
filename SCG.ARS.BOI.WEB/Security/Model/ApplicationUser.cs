using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Security.Model
{
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(100)]
        public string Domain { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(250)]
        public string FullName { get; set; }
        public string CustomerCode { get; set; }
        public DateTime? LastChangePasswordDate { get; set; }
        [Required]
        public bool MustChangePassword { get; set; }
        [Required]
        public bool IsExternal { get; set; }
        [Required]
        public bool IsDelete { get; set; }
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

    }
}
