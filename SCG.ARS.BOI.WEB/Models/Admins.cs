using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SCG.ARS.BOI.WEB.Models
{
    public partial class Admins
    {
        [Key]
        public int User_Id { get; set; }
        public string User_Code { get; set; }
        public string User_Name { get; set; }
        public string User_Email { get; set; }        
        public int? UserGroup_Id { get; set; }        
        public DateTime? Create_DateTime { get; set; }
        public DateTime? LastActive_DateTime { get; set; }
        public Roles Roles { get; set; }
    }

    public partial class Users
    {
        [Key]
        public int User_Id { get; set; }
        public string User_Code { get; set; }
        public string User_Name { get; set; }
        public string Password { get; set; }
        public string User_Email { get; set; }
        public string User_Department { get; set; }
        public int? UserGroup_Id { get; set; }
        public string UserGroup_Name { get; set; }
        public DateTime? Create_DateTime { get; set; }
        public DateTime? LastActive_DateTime { get; set; }
        public Roles Roles { get; set; }
        public bool IsAdmin { get; set; }
    }
}
