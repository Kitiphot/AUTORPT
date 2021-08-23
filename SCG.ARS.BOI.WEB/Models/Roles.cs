using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SCG.ARS.BOI.WEB.Models
{
    public partial class Roles
    {
        public Roles()
        {
            Admins = new HashSet<Admins>();
            LinkRolesMenus = new HashSet<LinkRolesMenus>();
        }
        [Key]
        public int UserGroup_Id { get; set; }
        public string UserGroup_Name { get; set; }
        public string UserGroup_Desc { get; set; }
        public string CreateUser_Code { get; set; }
        public DateTime Create_DateTime { get; set; }
        public string UpdateUser_Code { get; set; }
        public DateTime Update_DateTime { get; set; }

        public ICollection<Admins> Admins { get; set; }
        public ICollection<LinkRolesMenus> LinkRolesMenus { get; set; }
    }
}
