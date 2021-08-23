using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Security.Model
{
    public class UserModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Domain { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string CustomerCode { get; set; }
        public bool IsExternal { get; set; }
        public List<string> AddRoles { get; set; }
        public List<string> DeleteRoles { get; set; }
    }
}
