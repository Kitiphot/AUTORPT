using System.Linq;
using System.Security.Claims;
using Microsoft.Extensions.Options;
//using System.Reflection.PortableExecutable;
namespace SCG.ARS.BOI.WEB.Services {
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System;
    //using SCG.ARS.BOI.WEB.GLSystemConfig;
    using System.Data;
    using System.Text;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.Configuration;
    using Models;
    using Novell.Directory.Ldap;
    using SCG.ARS.BOI.WEB.Helpers;
    using SCG.ARS.BOI.WEB.Configuration;

    public class UserService : IUserService {
        //private MyDbContext db = new MyDbContext ();

        //private readonly ILdapConnection _ldapConnection;
        private readonly IConfiguration _configuration;
        private readonly AppSetting _appsetting;
        private readonly AdminSetting _supAdmin;
        //private readonly GLSystemConfigContext _systemConfigContext;
        private readonly IHttpContextAccessor _httpContextAccessor;
        //private readonly IDictionary<string, Users> _users;

        //public UserService(IDictionary<string, Users> users) => _users = users;

        private string _userCode;
        private string _userGroupId;
        private readonly IAuthenticationService _authService;
        public UserService (IConfiguration configuration,
            IOptions<AppSetting> setting,
            IOptions<AdminSetting> supAdmin,
            IHttpContextAccessor httpContextAccessor,
            //GLSystemConfigContext systemConfigContext,
            IAuthenticationService authService
            //ILdapConnection ldapConnection
        ) {
            _configuration = configuration;
            _appsetting = setting.Value;
            _supAdmin = supAdmin.Value;
            _httpContextAccessor = httpContextAccessor;
            //_systemConfigContext = systemConfigContext;
            //_ldapConnection = ldapConnection;
            _authService = authService;
            var httpContext = httpContextAccessor.HttpContext;
            var user = httpContext.User;
            _userCode = user.FindFirst (ClaimTypes.Sid) != null ? user.FindFirst (ClaimTypes.Sid).Value : "";
            _userGroupId = user.FindFirst (ClaimTypes.GroupSid) != null ? user.FindFirst (ClaimTypes.GroupSid).Value : "";
        }
        public string GenerateMenu () {
            string menu = string.Empty;

            if (!string.IsNullOrEmpty (_userGroupId)) {
                int groupId = int.Parse (_userGroupId);
                List<Menus> menus = GetMenus (groupId);

                DataSet ds = new DataSet ();
                ds = Helper.ToDataSet (menus);
                DataTable table = ds.Tables[0];
                DataRow[] parentMenus = table.Select ("menuparent_id = 0");

                var sb = new StringBuilder ();
                menu = Helper.GenerateUL (parentMenus, table, sb);
            }

            return menu;
        }
        public Users GetUsers (ClaimsPrincipal user) {
            var userCode = user.FindFirst (ClaimTypes.Sid).Value;
            return GetUser (userCode);
        }

        public Users GetUser (string userCode) {
            // var user = _systemConfigContext.TblMUser
            //     .Where(w => w.UserCode == userCode)
            //     .Select(s => new Users
            //     {
            //         User_Id = s.UserId,
            //         User_Code = s.UserCode,
            //         User_Name = s.UserName,
            //         User_Email = s.UserEmail,
            //         UserGroup_Id = s.UserGroupId,
            //         Roles = _systemConfigContext.TblMUsergroup.Where(w => w.UserGroupId == s.UserGroupId)
            //            .Select(r => new Roles
            //            {
            //                UserGroup_Id = r.UserGroupId,
            //                UserGroup_Name = r.UserGroupName,
            //                UserGroup_Desc = r.UserGroupDesc,
            //                CreateUser_Code = r.CreateUserCode,
            //                Create_DateTime = r.CreateDateTime,
            //                UpdateUser_Code = r.UpdateUserCode,
            //                Update_DateTime = r.CreateDateTime,
            //            }).FirstOrDefault()
            //     })
            //     .FirstOrDefault();
            // return user;
            return null;
        }

        public Admins GetAdmin (ClaimsPrincipal user) {
            var userCode = user.FindFirst (ClaimTypes.Sid).Value;
            return GetAdmin (userCode);
        }

        public Admins GetAdmin (string userCode) {
            Admins user = null;
            if (_supAdmin.UserCode.Equals (userCode)) {
                user = new Admins {
                    User_Id = 0,
                    User_Code = _supAdmin.UserCode,
                    User_Name = _supAdmin.UserName,
                    User_Email = _supAdmin.UserEmail,
                    UserGroup_Id = _supAdmin.UserGroupId,
                    Roles = null
                    // Roles = _systemConfigContext.TblMUsergroup.Where(w => w.UserGroupId == _supAdmin.UserGroupId)
                    // .Select(r => new Roles
                    // {
                    //     UserGroup_Id = r.UserGroupId,
                    //     UserGroup_Name = r.UserGroupName,
                    //     UserGroup_Desc = r.UserGroupDesc,
                    //     CreateUser_Code = r.CreateUserCode,
                    //     Create_DateTime = r.CreateDateTime,
                    //     UpdateUser_Code = r.UpdateUserCode,
                    //     Update_DateTime = r.CreateDateTime,
                    // }).FirstOrDefault()
                };
            } else {
                // user = _systemConfigContext.TblMUser
                //     .Where(w => w.UserCode == userCode)
                //     .Select(s => new Admins
                //     {
                //         User_Id = s.UserId,
                //         User_Code = s.UserCode,
                //         User_Name = s.UserName,
                //         User_Email = s.UserEmail,
                //         UserGroup_Id = s.UserGroupId,
                //         Roles = _systemConfigContext.TblMUsergroup.Where(w => w.UserGroupId == s.UserGroupId)
                //            .Select(r => new Roles
                //            {
                //                UserGroup_Id = r.UserGroupId,
                //                UserGroup_Name = r.UserGroupName,
                //                UserGroup_Desc = r.UserGroupDesc,
                //                CreateUser_Code = r.CreateUserCode,
                //                Create_DateTime = r.CreateDateTime,
                //                UpdateUser_Code = r.UpdateUserCode,
                //                Update_DateTime = r.CreateDateTime,
                //            }).FirstOrDefault()
                //     })
                //     .FirstOrDefault();
            }
            return user;
        }
        public Menus GetMenu (string menuCode) {
            // var menu = _systemConfigContext.TblMMenu
            //     .Where(w => w.MenuCode == menuCode)
            //     .Select(m => new Menus
            //     {
            //         Menu_Id = m.MenuId,
            //         Menu_Code = m.MenuCode,
            //         Menu_Name = m.MenuName,
            //         Menu_Icon = m.MenuIcon,
            //         Menu_Url = m.MenuUrl,
            //         MenuParent_Id = m.MenuParentId,
            //         Sorting_no = m.SortingNo,
            //         Active_Flag = m.ActiveFlag,
            //         CreateUser_Code = m.CreateUserCode,
            //         Create_DateTime = m.CreateDateTime,
            //         UpdateUser_Code = m.UpdateUserCode,
            //         Update_DateTime = m.UpdateDateTime,
            //     }).FirstOrDefault();
            // return menu;
            return null;
        }
        public List<Menus> GetMenus (int userGroupId) {
            // var menus = _systemConfigContext.TblMGrouppermission
            //     .Join(_systemConfigContext.TblMMenu, p => p.MenuId, d => d.MenuId, (p, d) => new { p, d })
            //     .Where(s => s.p.UserGroupId == userGroupId && s.d.ActiveFlag == true)
            //     .Select(m => new Menus
            //     {
            //         Menu_Id = m.d.MenuId,
            //         Menu_Code = m.d.MenuCode,
            //         Menu_Name = m.d.MenuName,
            //         Menu_Icon = m.d.MenuIcon,
            //         Menu_Url = m.d.MenuUrl,
            //         MenuParent_Id = m.d.MenuParentId,
            //         Sorting_no = m.d.SortingNo,
            //         Active_Flag = m.d.ActiveFlag,
            //         CreateUser_Code = m.d.CreateUserCode,
            //         Create_DateTime = m.d.CreateDateTime,
            //         UpdateUser_Code = m.d.UpdateUserCode,
            //         Update_DateTime = m.d.UpdateDateTime,
            //     })
            //     .OrderBy(o => o.MenuParent_Id)
            //     .ThenBy(t => t.Sorting_no).ToList();
            // return menus;
            return null;
        }

        public Task < (bool, Users) > ValidateUserCredentialsAsync (string username, string password) {
            var isValid = false;
            Users user = null;

            if (_supAdmin.UserCode.Equals (username) && _supAdmin.Password.Equals (password)) {
                isValid = true;
                
                var roles = new Roles {
                    UserGroup_Id = 1,
                    UserGroup_Name = "Admin",
                    UserGroup_Desc = "Admin",
                    CreateUser_Code = "System",
                    Create_DateTime = DateTime.Now,
                    UpdateUser_Code = "System",
                    Update_DateTime = DateTime.Now,
                };

                user = new Users
                {
                    User_Id = 0,
                    User_Code = _supAdmin.UserCode,
                    User_Name = _supAdmin.UserName,
                    User_Email = _supAdmin.UserEmail,
                    UserGroup_Id = _supAdmin.UserGroupId,
                    Roles = roles,
                    UserGroup_Name = roles.UserGroup_Name,
                    Create_DateTime = DateTime.MinValue,
                    LastActive_DateTime = DateTime.Now,
                    IsAdmin = true
                };

                // var roles = _systemConfigContext.TblMUsergroup.Where(w => w.UserGroupId == _supAdmin.UserGroupId)
                //     .Select(s => new Roles
                //     {
                //         UserGroup_Id = s.UserGroupId,
                //         UserGroup_Name = s.UserGroupName,
                //         UserGroup_Desc = s.UserGroupDesc,
                //         CreateUser_Code = s.CreateUserCode,
                //         Create_DateTime = s.CreateDateTime,
                //         UpdateUser_Code = s.UpdateUserCode,
                //         Update_DateTime = s.CreateDateTime,
                //     }).FirstOrDefault();
                // user = new Users
                // {
                //     User_Id = 0,
                //     User_Code = _supAdmin.UserCode,
                //     User_Name = _supAdmin.UserName,
                //     User_Email = _supAdmin.UserEmail,
                //     UserGroup_Id = _supAdmin.UserGroupId,
                //     Roles = roles,
                //     UserGroup_Name = roles.UserGroup_Name,
                //     Create_DateTime = DateTime.MinValue,
                //     LastActive_DateTime = DateTime.Now,
                //     IsAdmin = true
                // };
            } else {
                Users ldapUser = _authService.Login (username, password);
                //Users ldapUser = !Helpers.Helper.IsDebug ? _authService.Login(username, password) : null;
                //if (ldapUser != null || Helpers.Helper.IsDebug)
                if (true)
                //if (ldapUser != null)
                {
                    var usr = User.GetUser();
                    //_systemConfigContext.TblMUser.Where(w => w.UserCode == username).FirstOrDefault();
                    if (usr != null)
                    {
                        user = new Users
                        {
                            User_Id = usr.User_Id,
                            User_Code = usr.User_Code,
                            User_Name = usr.User_Name,
                            User_Email = usr.User_Email,
                            UserGroup_Id = usr.UserGroup_Id,
                            Roles = null,
                            // Roles = _systemConfigContext.TblMUsergroup.Where(w => w.UserGroupId == usr.UserGroupId)
                            // .Select(s => new Roles
                            // {
                            //     UserGroup_Id = s.UserGroupId,
                            //     UserGroup_Name = s.UserGroupName,
                            //     UserGroup_Desc = s.UserGroupDesc,
                            //     CreateUser_Code = s.CreateUserCode,
                            //     Create_DateTime = s.CreateDateTime,
                            //     UpdateUser_Code = s.UpdateUserCode,
                            //     Update_DateTime = s.CreateDateTime,
                            // }).FirstOrDefault(),
                            Create_DateTime = usr.Create_DateTime,
                            LastActive_DateTime = DateTime.Now
                        };

                        // usr.LastActiveDateTime = DateTime.Now;
                        // _systemConfigContext.TblMUser.Update(usr);
                        // _systemConfigContext.SaveChanges();
                        isValid = true;
                    }
                    else if (ldapUser != null)
                    {
                        // usr = new TblMUser
                        // {
                        //     UserCode = ldapUser.User_Code,
                        //     UserName = ldapUser.User_Name,
                        //     UserEmail = ldapUser.User_Email,
                        //     UserGroupId = 0,
                        //     CreateDateTime = DateTime.Now,
                        //     LastActiveDateTime = DateTime.Now,
                        // };

                        // _systemConfigContext.TblMUser.Add(usr);
                        // _systemConfigContext.SaveChanges();

                        user = new Users
                        {
                            User_Id = usr.User_Id,
                            User_Code = usr.User_Code,
                            User_Name = usr.User_Name,
                            User_Email = usr.User_Email,
                            UserGroup_Id = usr.UserGroup_Id,
                            Create_DateTime = usr.Create_DateTime,
                            LastActive_DateTime = usr.LastActive_DateTime
                        };
                        isValid = true;
                    }
                }
            }
            var result = (isValid, user);
            // var isValid = _users.ContainsKey(username) && 
            //               string.Equals(_users[username].Password, password, StringComparison.Ordinal);
            // var result = (isValid, isValid ? _users[username] : null);
            return Task.FromResult (result);
        }

        public List<LinkRolesMenus> GetPermissions (ClaimsPrincipal user, string menuCode) {
            var userGroupId = user.FindFirst (ClaimTypes.GroupSid).Value;
            // var permissions = db.LinkRolesMenus.Where (w => w.UserGroup_Id.ToString () == userGroupId && w.Menus.Menu_Code == menuCode).ToList ();
            // foreach (var permission in permissions) {
            //     permission.Menus = db.Menus.Where (w => w.Menu_Code == menuCode).FirstOrDefault ();
            //     permission.Roles = db.Roles.Where (w => w.UserGroup_Id.ToString () == userGroupId).FirstOrDefault ();
            // }
            // var menu = _systemConfigContext.TblMMenu.Where(w => w.MenuCode == menuCode).FirstOrDefault();
            // var permissions = new List<LinkRolesMenus>();
            // if (menu != null)
            // {
            //     permissions = _systemConfigContext.TblMGrouppermission
            //         .Where(w => w.UserGroupId.ToString() == userGroupId && w.MenuId == menu.MenuId)
            //         .Select(s => new LinkRolesMenus
            //         {
            //             UserGroup_Id = s.UserGroupId,
            //             Menu_Id = s.MenuId,
            //             FullControl_Flag = s.FullControlFlag,
            //             ReadOnly_Flag = s.ReadOnlyFlag,
            //             CreateUser_Code = s.CreateUserCode,
            //             Create_DateTime = s.CreateDateTime,
            //             UpdateUser_Code = s.UpdateUserCode,
            //             Update_DateTime = s.UpdateDateTime,

            //             Menus = _systemConfigContext.TblMMenu
            //                .Select(m => new Menus
            //                {
            //                    Menu_Id = m.MenuId,
            //                    Menu_Code = m.MenuCode,
            //                    Menu_Name = m.MenuName,
            //                    Menu_Icon = m.MenuIcon,
            //                    Menu_Url = m.MenuUrl,
            //                    MenuParent_Id = m.MenuParentId,
            //                    Sorting_no = m.SortingNo,
            //                    Active_Flag = m.ActiveFlag,
            //                    CreateUser_Code = m.CreateUserCode,
            //                    Create_DateTime = m.CreateDateTime,
            //                    UpdateUser_Code = m.UpdateUserCode,
            //                    Update_DateTime = m.UpdateDateTime,
            //                }).FirstOrDefault(),

            //             Roles = _systemConfigContext.TblMUsergroup.Where(w => w.UserGroupId == s.UserGroupId)
            //                .Select(r => new Roles
            //                {
            //                    UserGroup_Id = r.UserGroupId,
            //                    UserGroup_Name = r.UserGroupName,
            //                    UserGroup_Desc = r.UserGroupDesc,
            //                    CreateUser_Code = r.CreateUserCode,
            //                    Create_DateTime = r.CreateDateTime,
            //                    UpdateUser_Code = r.UpdateUserCode,
            //                    Update_DateTime = r.CreateDateTime,
            //                }).FirstOrDefault(),
            //         }).ToList();

            //     if (permissions.Count == 0)
            //         permissions.Add(new LinkRolesMenus
            //         {
            //             FullControl_Flag = false,
            //             ReadOnly_Flag = false,
            //         });
            // }
            // else
            // {
            //     permissions.Add(new LinkRolesMenus
            //     {
            //         FullControl_Flag = false,
            //         ReadOnly_Flag = false,
            //     });
            // }

            //return permissions;

            return null;
        }

        // public Users LdapAuthenticate () {
        //     // var domain = "ldap.forumsys.com";
        //     // var port = 389;
        //     // var userName = "tesla";
        //     // var password = "password";

        //     // var isValid = false;
        //     Users Users = null;

        //     try {
        //         IConfigurationSection ldap = _configuration.GetSection ("ldap");
        //         //var ldapConn = GetConnection ();
        //         HashSet<string> groups = new HashSet<string> ();
        //         SearchForUser ("Finance and Accounting", groups);

        //         //SearchForGroup("Finance and Accounting");
        //         // DirectoryEntry entry = new DirectoryEntry ($"LDAP://{domain}:{port}", userName, password);
        //         // object nativeObject = entry.NativeObject;

        //         // DirectorySearcher searcher = new DirectorySearcher (entry);
        //         // searcher.PropertiesToLoad.Add ("samaccountname");
        //         // searcher.PropertiesToLoad.Add ("mail");
        //         // searcher.PropertiesToLoad.Add ("usergroup");
        //         // searcher.PropertiesToLoad.Add ("displayname");
        //         // searcher.PropertiesToLoad.Add ("department");
        //         // searcher.PropertiesToLoad.Add ("username");

        //         // SearchResult result;
        //         // SearchResultCollection resultCollection = searcher.FindAll ();
        //         // if (resultCollection != null) {
        //         //     for (int i = 0; i < resultCollection.Count; i++) {
        //         //         string emailString = string.Empty;
        //         //         result = resultCollection[i];
        //         //         if(result.Properties.Contains("samaccountname") && 
        //         //         result.Properties.Contains("mail") && 
        //         //         result.Properties.Contains("displayname") && 
        //         //         result.Properties.Contains("department"))
        //         //         {
        //         //             Users user = new Users{
        //         //                 User_Code = (string)result.Properties["samaccountname"][0],
        //         //                 User_Name = (string)result.Properties["displayname"][0],
        //         //                 User_Email = (string)result.Properties["mail"][0] + "^" + (string)result.Properties["displayname"][0],
        //         //                 User_Department = (string)result.Properties["department"][0],
        //         //             };
        //         //         }
        //         //     }
        //         // }
        //     } catch (Exception ex) {
        //         throw ex;
        //     }

        //     //var result = (isValid, Users);
        //     //return Task.FromResult (result);
        //     return Users;
        // }

        // private ILdapConnection GetConnection () {
        //     LdapConnection ldapConn = _ldapConnection as LdapConnection;

        //     if (ldapConn == null) {
        //         // Creating an LdapConnection instance 
        //         ldapConn = new LdapConnection () { SecureSocketLayer = false };

        //         //Connect function will create a socket connection to the server - Port 389 for insecure and 3269 for secure    
        //         ldapConn.Connect ("ldap.forumsys.com", 389);

        //         //Bind function with null user dn and password value will perform anonymous bind to LDAP server 
        //         ldapConn.Bind (@"cn=read-only-admin,dc=example,dc=com", "password");
        //     }

        //     return ldapConn;
        // }

        // private HashSet<string> SearchForGroup (string groupName) {
        //     var ldapConn = GetConnection ();
        //     var groups = new HashSet<string> ();

        //     var searchBase = string.Empty;
        //     var filter = $"(&(objectClass=group)(cn={groupName}))";
        //     var search = ldapConn.Search (searchBase, LdapConnection.SCOPE_SUB, filter, null, false);
        //     while (search.hasMore ()) {
        //         var nextEntry = search.next ();
        //         groups.Add (nextEntry.DN);
        //         var childGroups = GetChildren (string.Empty, nextEntry.DN);
        //         foreach (var child in childGroups) {
        //             groups.Add (child);
        //         }
        //     }

        //     return groups;
        // }

        // private HashSet<string> GetChildren (string searchBase, string groupDn, string objectClass = "group") {
        //     var ldapConn = GetConnection ();
        //     var listNames = new HashSet<string> ();

        //     var filter = $"(&(objectClass={objectClass})(memberOf={groupDn}))";
        //     var search = ldapConn.Search (searchBase, LdapConnection.SCOPE_SUB, filter, null, false);

        //     while (search.hasMore ()) {
        //         var nextEntry = search.next ();
        //         listNames.Add (nextEntry.DN);
        //         var children = GetChildren (string.Empty, nextEntry.DN);
        //         foreach (var child in children) {
        //             listNames.Add (child);
        //         }
        //     }

        //     return listNames;
        // }

        // private void SearchForUser (string department, HashSet<string> groups = null) {
        //     var ldapConn = GetConnection ();
        //     var users = new HashSet<string> ();

        //     string groupFilter = (groups?.Count ?? 0) > 0 ?
        //         $"(|{string.Join("", groups.Select(x => $"(memberOf={x})").ToList())})" :
        //         string.Empty;
        //     var searchBase = string.Empty;
        //     //string filter = $"(&(objectClass=user)(objectCategory=person)(department={department}){groupFilter})";
        //     string filter = $"(&(objectClass=user)(objectCategory=person))";
        //     var search = ldapConn.Search (searchBase, LdapConnection.SCOPE_SUB, filter, null, false);

        //     while (search.hasMore ()) {
        //         var nextEntry = search.next ();
        //         nextEntry.getAttributeSet ();
        //         users.Add (nextEntry.DN);
        //     }
        // }
    }
}