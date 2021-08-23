using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Security.Model
{
    public class CookieTokenModel
    {
        public string Username { get; set; }
        public string CookieToken { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
