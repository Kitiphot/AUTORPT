using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SCG.ARS.BOI.WEB.Models
{
    public partial class Menus
    {
        public Menus()
        {
            LinkRolesMenus = new HashSet<LinkRolesMenus>();
        }

        [Key]
        public int Menu_Id { get; set; }
        public string Menu_Code { get; set; }
        public string Menu_Name { get; set; }
        public string Menu_Icon { get; set; }
        public string Menu_Url { get; set; }
        public int MenuParent_Id { get; set; }
        public int Sorting_no { get; set; }
        public bool? Active_Flag { get; set; }
        public string CreateUser_Code { get; set; }
        public DateTime Create_DateTime { get; set; }
        public string UpdateUser_Code { get; set; }
        public DateTime Update_DateTime { get; set; }

        public ICollection<LinkRolesMenus> LinkRolesMenus { get; set; }
    }
}
