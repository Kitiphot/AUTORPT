using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Security.Model
{
    public class ExternalAccess
    {
        [Required]
        [MaxLength(50)]
        public string SourceSystem { get; set; }
        [Required]
        [MaxLength(100)]
        public string SecretKey { get; set; }
        [Required]
        [MaxLength(100)]
        public string Issuer { get; set; }
        [Required]
        [MaxLength(100)]
        public string Audience { get; set; }
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
