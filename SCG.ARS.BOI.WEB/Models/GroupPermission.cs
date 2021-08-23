using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SCG.ARS.BOI.WEB.Models {
    public class GroupPermission {
        [Key]
        public int GroupPermission_Id { get; set; }
        public int UserGroup_Id { get; set; }
        public int Menu_Id { get; set; }
        public int FullControl_Flag { get; set; }
        public int ReadOnly_Flag { get; set; }
        public string CreateUser_Code { get; set; }
        public DateTime Create_DateTime { get; set; }
        public string UpdateUser_Code { get; set; }
        public DateTime Update_DateTime { get; set; }
    }
}