using System;
using System.Collections.Generic;
using SCG.ARS.BOI.WEB.Models;

namespace SCG.ARS.BOI.WEB.Models {
    public class User {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public static Users GetUser () {
            var roles = new Roles {
                UserGroup_Id = 1,
                UserGroup_Name = "Admin",
                UserGroup_Desc = "Admin",
                CreateUser_Code = "System",
                Create_DateTime = DateTime.Now,
                UpdateUser_Code = "System",
                Update_DateTime = DateTime.Now,
            };

            return new Users {
                User_Id = 0,
                    User_Code = "System",
                    User_Name = "System",
                    User_Email = "System@Email.com",
                    UserGroup_Id = 1,
                    Roles = roles,
                    UserGroup_Name = roles.UserGroup_Name,
                    Create_DateTime = DateTime.MinValue,
                    LastActive_DateTime = DateTime.Now,
                    IsAdmin = true
            };
        }
    }
    public class DataMaster {
        public string Code { get; set; }
        public string Name { get; set; }
    }
    public class ListUserMasterViewModel {
        public List<DataMaster> UserMaster { get; set; }
        public List<LinkRolesMenus> Permission { get; set; }
    }
}