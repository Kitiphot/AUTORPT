using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Account.Manage.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using NLog;
using Novell.Directory.Ldap;
using SCG.ARS.BOI.WEB.Attributes;
using SCG.ARS.BOI.WEB.Security;
using SCG.ARS.BOI.WEB.Security.Model;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SCG.ARS.BOI.WEB.Controllers
{
    public class SecurityController : Controller
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly UserManager<ApplicationUser> userMngr;
        private readonly RoleManager<ApplicationRole> roleMngr;
        private readonly SignInManager<ApplicationUser> signInMngr;
        private readonly IUserRepository ur;
        private readonly IRoleRepository rr;
        private readonly IPermissionRepository pr;
        private readonly ISecurityService ss;
        static NLog.Logger logger = LogManager.GetCurrentClassLogger();
        public SecurityController(
            IHttpContextAccessor httpContextAccessor,
            UserManager<ApplicationUser> userMngr,
            RoleManager<ApplicationRole> roleMngr,
            SignInManager<ApplicationUser> signInMngr,
            IUserRepository ur,
            IRoleRepository rr,
            IPermissionRepository pr,
            ISecurityService ss)
        {
            this.httpContextAccessor = httpContextAccessor;
            this.userMngr = userMngr;
            this.roleMngr = roleMngr;
            this.signInMngr = signInMngr;
            this.ur = ur;
            this.rr = rr;
            this.pr = pr;
            this.ss = ss;
        }

        public IActionResult Index()
        {
            return View();
        }

        [WebAuthorize(ScreenID.WEB_USER, Permission.View)]
        public IActionResult WEB_USER()
        {
            return View();
        }

        [WebAuthorize(ScreenID.WEB_ROLE, Permission.View)]
        public IActionResult WEB_ROLE()
        {
            return View();
        }

        [WebAuthorize(ScreenID.WEB_EXTERNAL_ACCESS, Permission.View)]
        public IActionResult WEB_EXTERNAL_ACCESS()
        {
            return View();
        }

        [WebAuthorize(ScreenID.WEB_USER, Permission.View)]
        public IActionResult SearchUser(string criteria)
        {
            try
            {
                return Json(new { data = ur.Find(criteria).Select(c => new { c.UserName, c.Email, c.FirstName, c.LastName, c.CustomerCode, c.Domain, c.LastChangePasswordDate, c.IsDelete, c.CreatedBy, c.CreatedDate, c.UpdatedBy, c.UpdatedDate }).OrderBy(c => c.UserName).ToList(), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "SearchUser", criteria);
                return Json(new { data = ex.Message, success = false });
            }
        }

        [Authorize]
        public async Task<IActionResult> ChangePassword(PasswordModel model)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(model.OldPassword) && !model.SetPassword)
                    return Json(new { data = "Old Password is required.", success = false });
                if (string.IsNullOrWhiteSpace(model.NewPassword))
                    return Json(new { data = "New Password is required.", success = false });

                if (model.SetPassword)
                {
                    if (!SecurityHelpers.IsAllow(httpContextAccessor.HttpContext.User, ScreenID.WEB_USER, Permission.Edit))
                        return Json(new { data = "You has no permission to set password.", success = false });
                }
                else
                    model.Username = httpContextAccessor.HttpContext.User.Identity.Name;

                var vResult = await ss.ValidatePassword(model.Username, model.NewPassword);
                if (!vResult.IsValid)
                {
                    return Json(new { data = string.Join("<br/>", vResult.Errors), success = false });
                }

                var user = await userMngr.FindByNameAsync(model.Username);
                user.LastChangePasswordDate = DateTime.Now;
                user.MustChangePassword = false;
                user.UpdatedBy = httpContextAccessor.HttpContext.User.Identity.Name;
                user.UpdatedDate = DateTime.Now;
                IdentityResult result;
                if (model.SetPassword) {
                    var token = await userMngr.GeneratePasswordResetTokenAsync(user);
                    result = await userMngr.ResetPasswordAsync(user, token, model.NewPassword.ToHash());
                }
                else {
                    result = await userMngr.ChangePasswordAsync(user, model.OldPassword.ToHash(), model.NewPassword.ToHash());
                }

                if (result.Succeeded)
                {
                    if (user.Domain == "External")
                    {
                        pr.RecordPasswords(user.UserName, model.NewPassword.ToHash(), httpContextAccessor.HttpContext.User.Identity.Name);
                    }
                    return Json(new { data = !result.Succeeded ? string.Join(' ', result.Errors) : "", success = result.Succeeded });
                }
                else
                {
                    return Json(new { data = string.Join("<br/>", result.Errors.Select(c => c.Description)), success = false });
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "ChangePassword", Newtonsoft.Json.JsonConvert.SerializeObject(model));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [WebAuthorize(ScreenID.WEB_USER, Permission.Delete)]
        public async Task<IActionResult> DeleteUser(string username)
        {
            try
            {
                var user = await userMngr.FindByNameAsync(username);
                if (user == null)
                    return Json(new { data = "User does not exists.", success = false });
                else if (user.UserName == ss.GetAdminUser())
                    return Json(new { data = "Cannot delete administrator user.", success = false });
                else
                {
                    var result = ur.Delete(user, httpContextAccessor.HttpContext.User.Identity.Name);
                }
                return Json(new { data = "", success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "DeleteUser", username);
                return Json(new { data = ex.Message, success = false });
            }
        }

        [WebAuthorize(ScreenID.WEB_USER, Permission.Add)]
        public async Task<IActionResult> RestoreUser(string username)
        {
            try
            {
                var user = await userMngr.FindByNameAsync(username);
                if (user == null)
                    return Json(new { data = "User does not exists.", success = false });
                else
                {
                    var result = ur.Restore(user, httpContextAccessor.HttpContext.User.Identity.Name);
                }
                return Json(new { data = "", success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "RestoreUser", username);
                return Json(new { data = ex.Message, success = false });
            }
        }

        [WebAuthorize(ScreenID.WEB_USER, Permission.Edit)]
        public async Task<IActionResult> EditUser(UserModel um)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(um.FirstName))
                    return Json(new { data = "FirstName is required.", success = false });
                if (string.IsNullOrWhiteSpace(um.LastName))
                    return Json(new { data = "LastName is required.", success = false });
                if (string.IsNullOrWhiteSpace(um.Email))
                    return Json(new { data = "Email is required.", success = false });

                var user = await userMngr.FindByNameAsync(um.Username);
                if (user == null)
                    return Json(new { data = "User does not exists.", success = false });
                else
                {
                    user.FirstName = um.FirstName;
                    user.LastName = um.LastName;
                    user.FullName = $"{um.FirstName} {um.LastName}";
                    user.Domain = um.Domain;
                    user.CustomerCode = um.CustomerCode;
                    user.Email = um.Email;
                    user.UpdatedBy = httpContextAccessor.HttpContext.User.Identity.Name;
                    user.UpdatedDate = DateTime.Now;
                    var result = await userMngr.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        using var tran = new TransactionScope();
                        if (um.DeleteRoles != null)
                        {
                            foreach (var roleName in um.DeleteRoles)
                            {
                                ur.RemoveRole(user, roleName, httpContextAccessor.HttpContext.User.Identity.Name);
                            }
                        }
                        if (um.AddRoles != null)
                        {
                            foreach (var roleName in um.AddRoles)
                            {
                                ur.AddRole(user, roleName, httpContextAccessor.HttpContext.User.Identity.Name);
                            }
                        }
                        tran.Complete();
                    }
                    return Json(new { data = !result.Succeeded ? string.Join(' ', result.Errors) : "", success = result.Succeeded });
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "EditUser", Newtonsoft.Json.JsonConvert.SerializeObject(um));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [WebAuthorize(ScreenID.WEB_USER, Permission.Add)]
        public async Task<IActionResult> CreateUser(UserModel um)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(um.FirstName))
                    return Json(new { data = "FirstName is required.", success = false });
                if (string.IsNullOrWhiteSpace(um.LastName))
                    return Json(new { data = "LastName is required.", success = false });
                if (string.IsNullOrWhiteSpace(um.Email))
                    return Json(new { data = "E-mail is required.", success = false });
                if (string.IsNullOrWhiteSpace(um.Password) && um.Domain == "External")
                    return Json(new { data = "Password is required.", success = false });
                else if (um.Domain == "External")
                {
                    var vResult = await ss.ValidatePassword(um.Username, um.Password);
                    if (!vResult.IsValid)
                    {
                        return Json(new { data = string.Join("<br/>", vResult.Errors), success = false });
                    }
                }

                var user = await userMngr.FindByNameAsync(um.Username);
                
                if (user == null)
                {
                    user = new ApplicationUser();
                    user.UserName = um.Username;
                    user.NormalizedUserName = um.Username.Normalize().ToUpper();
                    user.Email = um.Email;
                    user.NormalizedEmail = um.Email.Normalize().ToUpper();
                    user.FirstName = um.FirstName;
                    user.LastName = um.LastName;
                    user.FullName = $"{um.FirstName} {um.LastName}";
                    user.Domain = um.Domain;
                    user.CustomerCode = um.CustomerCode;
                    user.ConcurrencyStamp = Guid.NewGuid().ToString();
                    user.SecurityStamp = Guid.NewGuid().ToString();
                    user.LastChangePasswordDate = null;
                    user.IsDelete = false;
                    //user.IsExternal = um.IsExternal;
                    user.CreatedBy = httpContextAccessor.HttpContext.User.Identity.Name;
                    user.CreatedDate = DateTime.Now;
                    user.UpdatedBy = httpContextAccessor.HttpContext.User.Identity.Name;
                    user.UpdatedDate = DateTime.Now;
                    IdentityResult result;
                    if (um.Domain == "External")
                        result = await userMngr.CreateAsync(user, um.Password.ToHash());
                    else
                        result = await userMngr.CreateAsync(user);

                    if (result.Succeeded)
                    {
                        using var tran = new TransactionScope();

                        if (um.Domain == "External")
                        {
                            pr.RecordPasswords(um.Username, um.Password.ToHash(), httpContextAccessor.HttpContext.User.Identity.Name);
                        }
                        if (um.DeleteRoles != null)
                        {
                            foreach (var roleName in um.DeleteRoles)
                            {
                                ur.RemoveRole(user, roleName, httpContextAccessor.HttpContext.User.Identity.Name);
                            }
                        }
                        if (um.AddRoles != null)
                        {
                            foreach (var roleName in um.AddRoles)
                            {
                                ur.AddRole(user, roleName, httpContextAccessor.HttpContext.User.Identity.Name);
                            }
                        }
                        tran.Complete();
                    }
                    return Json(new { data = !result.Succeeded ? string.Join(' ', result.Errors) : "", success = result.Succeeded });
                }
                else
                {
                    return Json(new { data = "Username already exists.", success = false });
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "CreateUser", Newtonsoft.Json.JsonConvert.SerializeObject(um));
                return Json(new { data = ex.Message, success = false });
            }
        }
        [WebAuthorize(ScreenID.WEB_USER, Permission.Edit)]
        public async Task<IActionResult> AddUserToRole(UserRoleModel urm)
        {
            try
            {
                var user = await userMngr.FindByNameAsync(urm.Username);
                if (user != null)
                {
                    int result = ur.AddRole(user, urm.Role, httpContextAccessor.HttpContext.User.Identity.Name);
                    if (result == -1)
                        return Json(new { data = "Role does not exists.", success = false });
                    //else if (result == -2)
                    //    return Json(new { data = $"User already assign to {urm.Role}", success = false });
                    else
                        return Json(new { data = "", success = true });
                }
                else
                {
                    return Json(new { data = "Username does not exists.", success = false });
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "AddUserToRole", Newtonsoft.Json.JsonConvert.SerializeObject(urm));
                return Json(new { data = ex.Message, success = false });
            }
        }
        [WebAuthorize(ScreenID.WEB_USER, Permission.View)]
        public async Task<IActionResult> UserPermission(PermissionModel input)
        {
            try
            {
                var user = await userMngr.FindByNameAsync(input.Key);
                var claims = await userMngr.GetClaimsAsync(user);
                var menu = pr.GetMenu();
                var permissions = pr.GetScreenPermission();
                List<ScreenModel> addList = new List<ScreenModel>();
                foreach (var item in menu.Where(c => !string.IsNullOrEmpty(c.MenuRoute)))
                {
                    foreach (var perm in permissions.Where(c => c.MenuID == item.MenuID))
                    {
                        bool allow = false;
                        if (!string.IsNullOrEmpty(item.MenuRoute))
                            allow = claims.Any(c => item.MenuCode.Equals(c.Value, StringComparison.InvariantCultureIgnoreCase) && c.Type == perm.Permission);
                        ScreenModel security = new ScreenModel
                        {
                            MenuID = item.MenuID,
                            MenuCode = item.MenuCode,
                            MenuIcon = item.MenuIcon,
                            MenuName = item.MenuName,
                            MenuPath = item.MenuPath,
                            MenuRoute = item.MenuRoute,
                            Order = item.Order,
                            Allow = allow,
                            Depth = item.Depth + 1,
                            Permission = perm.Permission,
                            OrderPath = item.OrderPath
                        };
                        addList.Add(security);
                    }
                    item.MenuRoute = null;
                }
                menu.AddRange(addList);
                return Json(new { data = menu.OrderBy(c => c.OrderPath).ThenBy(c => c.Depth).ThenBy(c => c.Permission), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "UserPermission", input.Key);
                return Json(new { data = ex.Message, success = false });
            }
        }
        [WebAuthorize(ScreenID.WEB_USER, Permission.Edit)]
        public async Task<IActionResult> SetUserPermission(PermissionModel userPerm)
        {
            try
            {
                var currentUser = httpContextAccessor.HttpContext.User.Identity.Name;
                var user = await userMngr.FindByNameAsync(userPerm.Key);
                var claims = await userMngr.GetClaimsAsync(user);
                foreach(var addClaim in userPerm.Permissions.Where(c => c.IsAllow == 1).Select(c => new Claim(c.ClaimType, c.ClaimValue)))
                {
                    ur.AddClaim(user, addClaim, currentUser);
                }
                var removeClaims = claims
                    .Where(c => userPerm.Permissions.Where(c => c.IsAllow == 0)
                    .Any(f => c.Type == f.ClaimType && c.Value.Equals(f.ClaimValue, StringComparison.InvariantCultureIgnoreCase)));
                if (removeClaims != null)
                    await userMngr.RemoveClaimsAsync(user, removeClaims);
                return Json(new { data = "", success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "SetUserPermission", Newtonsoft.Json.JsonConvert.SerializeObject(userPerm));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [WebAuthorize(ScreenID.WEB_ROLE, Permission.View)]
        public IActionResult SearchRole(string criteria)
        {
            try
            {
                return Json(new { data = rr.Find(criteria).Select(c => new { RoleID = c.Id, RoleName = c.Name, c.Category, c.CreatedBy, c.CreatedDate, c.UpdatedBy, c.UpdatedDate }).OrderBy(c => c.RoleName).ToList(), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "SearchRole", criteria);
                return Json(new { data = ex.Message, success = false });
            }
        }
        [WebAuthorize(ScreenID.WEB_ROLE, Permission.View)]
        public async Task<IActionResult> RolePermission(PermissionModel data)
        {
            try
            {
                var role = await roleMngr.FindByIdAsync(data.Key);
                var claims = await roleMngr.GetClaimsAsync(role);
                var menu = pr.GetMenu();
                var permissions = pr.GetScreenPermission();
                List<ScreenModel> addList = new List<ScreenModel>();
                foreach (var item in menu.Where(c => !string.IsNullOrEmpty(c.MenuRoute)))
                {
                    foreach (var perm in permissions.Where(c => c.MenuID == item.MenuID))
                    {
                        bool allow = false;
                        if (!string.IsNullOrEmpty(item.MenuRoute))
							//allow = claims.Any(c => item.MenuRoute.EndsWith($"/{c.Value}") && c.Type == perm.Permission);
							allow = claims.Any(c => item.MenuCode.Equals(c.Value, StringComparison.OrdinalIgnoreCase) && c.Type == perm.Permission);

						ScreenModel security = new ScreenModel 
						{
							MenuID = item.MenuID,
							MenuCode = item.MenuCode,
							MenuIcon = item.MenuIcon,
							MenuName = item.MenuName,
							MenuPath = item.MenuPath,
							MenuRoute = item.MenuRoute,
							Order = item.Order,
							Allow = allow,
							Depth = item.Depth + 1,
							Permission = perm.Permission,
							OrderPath = item.OrderPath
						};

                        addList.Add(security);
                    }
                    item.MenuRoute = null;
                }
                menu.AddRange(addList);
                return Json(new { data = menu.OrderBy(c => c.OrderPath).ThenBy(c => c.Depth).ThenBy(c => c.Permission), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "RolePermission", data.Key);
                return Json(new { data = ex.Message, success = false });
            }
        }

        [WebAuthorize(ScreenID.WEB_ROLE, Permission.Delete)]
        public async Task<IActionResult> DeleteRole(string roleID)
        {
            try
            {
                var role = await roleMngr.FindByIdAsync(roleID);
                if (role == null)
                    return Json(new { data = "Role does not exists.", success = false });
                else if (role.Name == ss.GetAdminRole())
                    return Json(new { data = "Cannot delete administrator role.", success = false });
                else
                {
                    //var users = await userMngr.GetUsersInRoleAsync(role.Name);
                    //if (users != null && users.Any(c => !c.IsDelete))
                    //{
                    //    return Json(new { data = "Cannot delete role.", success = false });
                    //}
                    var result = await roleMngr.DeleteAsync(role);
                    return Json(new { data = !result.Succeeded ? string.Join(' ', result.Errors) : "", success = result.Succeeded });
                }
                //return Json(new { data = "", success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "DeleteRole", roleID);
                return Json(new { data = ex.Message, success = false });
            }
        }

        [WebAuthorize(ScreenID.WEB_ROLE, Permission.Edit)]
        public async Task<IActionResult> EditRole(RoleModel rl)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(rl.RoleName))
                    return Json(new { data = "Role Name is required.", success = false });
                var roleName = await roleMngr.FindByNameAsync(rl.RoleName);
                if (roleName != null && roleName.Id != rl.RoleID)
                    return Json(new { data = "Role Name is duplicated", success = false });

                var role = await roleMngr.FindByIdAsync(rl.RoleID);
                if (role == null)
                    return Json(new { data = "Role does not exists.", success = false });
                else
                {
                    role.Name = rl.RoleName;
                    role.NormalizedName = rl.RoleName.Normalize().ToUpper();
                    role.Category = rl.Category;
                    role.UpdatedBy = httpContextAccessor.HttpContext.User.Identity.Name;
                    role.UpdatedDate = DateTime.Now;
                    var result = await roleMngr.UpdateAsync(role);
                    if (result.Succeeded)
                    {
                        using var tran = new TransactionScope();
                        if (rl.DeleteUsers != null)
                        {
                            foreach (var username in rl.DeleteUsers)
                            {
                                var user = await userMngr.FindByNameAsync(username);
                                ur.RemoveRole(user, rl.RoleName, httpContextAccessor.HttpContext.User.Identity.Name);
                            }
                        }
                        if (rl.AddUsers != null)
                        {
                            foreach (var username in rl.AddUsers)
                            {
                                var user = await userMngr.FindByNameAsync(username);
                                ur.AddRole(user, rl.RoleName, httpContextAccessor.HttpContext.User.Identity.Name);
                            }
                        }
                        tran.Complete();
                    }
                    return Json(new { data = !result.Succeeded ? string.Join(' ', result.Errors) : "", success = result.Succeeded });
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "EditRole", Newtonsoft.Json.JsonConvert.SerializeObject(rl));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [WebAuthorize(ScreenID.WEB_ROLE, Permission.Add)]
        public async Task<IActionResult> CreateRole(RoleModel rl)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(rl.RoleName))
                    return Json(new { data = "Role Name is required.", success = false });

                var role = await roleMngr.FindByNameAsync(rl.RoleName);
                if (role == null)
                {
                    role = new ApplicationRole();
                    role.Name = rl.RoleName;
                    role.NormalizedName = rl.RoleName.Normalize().ToUpper();
                    role.Category = rl.Category;
                    role.CreatedBy = httpContextAccessor.HttpContext.User.Identity.Name;
                    role.CreatedDate = DateTime.Now;
                    role.UpdatedBy = httpContextAccessor.HttpContext.User.Identity.Name;
                    role.UpdatedDate = DateTime.Now;
                    var result = await roleMngr.CreateAsync(role);
                    if (result.Succeeded)
                    {
                        using var tran = new TransactionScope();
                        if (rl.DeleteUsers != null)
                        {
                            foreach (var username in rl.DeleteUsers)
                            {
                                var user = await userMngr.FindByNameAsync(username);
                                ur.RemoveRole(user, rl.RoleName, httpContextAccessor.HttpContext.User.Identity.Name);
                            }
                        }
                        if (rl.AddUsers != null)
                        {
                            foreach (var username in rl.AddUsers)
                            {
                                var user = await userMngr.FindByNameAsync(username);
                                ur.AddRole(user, rl.RoleName, httpContextAccessor.HttpContext.User.Identity.Name);
                            }
                        }
                        tran.Complete();
                    }
                    return Json(new { data = !result.Succeeded ? string.Join(' ', result.Errors) : "", success = result.Succeeded });
                }
                else
                {
                    return Json(new { data = "Role already exists.", success = false });
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "CreateRole", Newtonsoft.Json.JsonConvert.SerializeObject(rl));
                return Json(new { data = ex.Message, success = false });
            }
        }
        [WebAuthorize(ScreenID.WEB_ROLE, Permission.Edit)]
        public async Task<IActionResult> SetRolePermission(PermissionModel rolePerm)
        {
            try
            {
                var currentUser = httpContextAccessor.HttpContext.User.Identity.Name;
                var role = await roleMngr.FindByIdAsync(rolePerm.Key);
                var claims = await roleMngr.GetClaimsAsync(role);

                using var tran = new TransactionScope();

                var removeClaims = claims
                    .Where(c => rolePerm.Permissions.Where(c => c.IsAllow == 0)
                    .Any(f => c.Type == f.ClaimType && c.Value.Equals(f.ClaimValue, StringComparison.InvariantCultureIgnoreCase)));
                if (removeClaims != null)
                {
                    foreach (var removeClaim in removeClaims)
                    {
                        rr.RemoveClaim(role, removeClaim, currentUser);
                    }
                }

                foreach (var addClaim in rolePerm.Permissions.Where(c => c.IsAllow == 1).Select(c => new Claim(c.ClaimType, c.ClaimValue)))
                {
                    rr.AddClaim(role, addClaim, currentUser);
                }
                tran.Complete();
                return Json(new { data = "", success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "SetRolePermission", Newtonsoft.Json.JsonConvert.SerializeObject(rolePerm));
                return Json(new { data = ex.Message, success = false });
            }
        }

        [WebAuthorize(ScreenID.WEB_ROLE, Permission.View)]
        public async Task<IActionResult> GetUserInRole(string roleID)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(roleID))
                    return Json(new { success = true });
                var role = await roleMngr.FindByIdAsync(roleID);
                if (role != null)
                {
                    var users = await userMngr.GetUsersInRoleAsync(role.Name);
                    return Json(new { data = users.Where(c => !c.IsDelete).Select(c => new { c.UserName, c.FirstName, c.LastName }).ToList(), success = true });
                }
                else
                {
                    return Json(new { data = "Role does not exists.", success = false });
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "GetUserInRole", roleID);
                return Json(new { data = ex.Message, success = false });
            }
        }

        [WebAuthorize(ScreenID.WEB_USER, Permission.View)]
        public async Task<IActionResult> GetUserRole(string username)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(username))
                    return Json(new { success = true });
                var user = await userMngr.FindByNameAsync(username);
                if (user != null)
                {
                    var roleNames = await userMngr.GetRolesAsync(user);
                    List<ApplicationRole> roles = new List<ApplicationRole>();
                    foreach(var roleName in roleNames)
                    {
                        var role = await roleMngr.FindByNameAsync(roleName);
                        roles.Add(role);
                    }
                    return Json(new { data = roles.Select(c => new { RoleID = c.Id, RoleName = c.Name, c.Category }).ToList(), success = true });
                }
                else
                {
                    return Json(new { data = "Role does not exists.", success = false });
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "GetUserRole", username);
                return Json(new { data = ex.Message, success = false });
            }
        }
        
        [HttpPost]
        [Authorize]
        public IActionResult ListSearchCriteria(SearchCriteriaModel model)
        {
            var currentUser = httpContextAccessor.HttpContext.User.Identity.Name;
            try
            {
                model.Username = currentUser;
                return Json(new { data = pr.ListCriteria(model), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "ListSearchCriteria", currentUser);
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        [Authorize]
        public IActionResult GetDefaultSearchCriteria(SearchCriteriaModel model)
        {
            var currentUser = httpContextAccessor.HttpContext.User.Identity.Name;
            try
            {
                model.Username = currentUser;
                return Json(new { data = pr.GetDefaultCriteria(model), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "GetDefaultSearchCriteria", currentUser);
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        [Authorize]
        public IActionResult SetDefaultCriteria(SearchCriteriaModel sc)
        {
            var currentUser = httpContextAccessor.HttpContext.User.Identity.Name;
            try
            {
                using var tran = new TransactionScope();
                sc.Username = currentUser;
                int result = pr.SetDefaultCriteria(sc);
                tran.Complete();
                return Json(new { data = "", success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "DeleteCriteria", currentUser);
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        [Authorize]
        public IActionResult DeleteCriteria(SearchCriteriaModel sc)
        {
            var currentUser = httpContextAccessor.HttpContext.User.Identity.Name;
            try
            {
                sc.Username = currentUser;
                using var tran = new TransactionScope();
                int result = pr.DeleteCriteria(sc);
                tran.Complete();
                return Json(new { data = "", success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "DeleteCriteria", currentUser);
                return Json(new { data = ex.Message, success = false });
            }
        }

        [HttpPost]
        [Authorize]
        public IActionResult SaveCriteria(SaveCriteria sc)
        {
            var currentUser = httpContextAccessor.HttpContext.User.Identity.Name;
            try
            {
                using var tran = new TransactionScope();
                int result = pr.SaveCriteria(sc.AllCriteria, currentUser);
                tran.Complete();
                return Json(new { data = "", success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "SaveCriteria", currentUser);
                return Json(new { data = ex.Message, success = false });
            }
        }

        [WebAuthorize(ScreenID.WEB_EXTERNAL_ACCESS, Permission.View)]
        public IActionResult SearchExternalAccess(string criteria)
        {
            try
            {
                return Json(new { data = pr.SearchExternalAccess(criteria), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "SearchExternalAccess", criteria);
                return Json(new { data = ex.Message, success = false });
            }
        }

        [WebAuthorize(ScreenID.WEB_EXTERNAL_ACCESS, Permission.Add)]
        public IActionResult GenerateExternalAccess(string sourceSystem)
        {
            var currentUser = httpContextAccessor.HttpContext.User.Identity.Name;
            try
            {
                if (pr.GetExternalAccess(sourceSystem) != null)
                    return Json(new { data = $"Source System is duplicated.", success = false });
                var result = pr.GenerateExternalAccess(sourceSystem, currentUser);
                return Json(new { data = result, success = result != null });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "GenerateExternalAccess", sourceSystem);
                return Json(new { data = ex.Message, success = false });
            }
        }

        [WebAuthorize(ScreenID.WEB_EXTERNAL_ACCESS, Permission.Delete)]
        public IActionResult DeleteExternalAccess(string sourceSystem)
        {
            var currentUser = httpContextAccessor.HttpContext.User.Identity.Name;
            try
            {
                return Json(new { data = pr.DeleteExternalAccess(sourceSystem, currentUser), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "GenerateExternalAccess", sourceSystem);
                return Json(new { data = ex.Message, success = false });
            }
        }

        [WebAuthorize(ScreenID.WEB_EXTERNAL_ACCESS, Permission.View)]
        public IActionResult TestExternalAccess(string sourceSystem)
        {
            var currentUser = httpContextAccessor.HttpContext.User.Identity.Name;
            try
            {
                return Json(new { data = GenerateJWTToken(currentUser, sourceSystem), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "GenerateExternalAccess", sourceSystem);
                return Json(new { data = ex.Message, success = false });
            }
        }

        string GenerateJWTToken(string username, string sourceSystem)
        {
            var ea = pr.GetExternalAccess(sourceSystem);
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(ea.SecretKey));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512);
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, username),
                new Claim(ClaimTypes.Name, username),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };
            var token = new JwtSecurityToken(
                issuer: ea.Issuer,
                audience: ea.Audience,
                claims: claims,
                notBefore: DateTime.UtcNow,
                expires: DateTime.UtcNow,
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }



        [Authorize]
        public IActionResult ListCriteriaConfig(string screenCode, string criteria)
        {
            try
            {
                return Json(new { data = pr.ListCriteriaConfig(criteria).Where(c => string.IsNullOrWhiteSpace(screenCode) || c.MenuCode == null || c.MenuCode == screenCode).OrderBy(c => c.CriteriaName), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "ListCriteriaConfig");
                return Json(new { data = ex.Message, success = false });
            }
        }
        [Authorize]
        public IActionResult ListCriteriaPermissionByUser(string key)
        {
            try
            {
                var menus = pr.GetMenu();
                var perms = pr.ListCriteriaPermissionByUser(key).OrderBy(c => c.MenuCode)
                    .ThenBy(c => c.CriteriaName);
                foreach(var perm in perms)
                {
                    perm.MenuDisplay = menus.FirstOrDefault(c => c.MenuCode == perm.MenuCode)?.MenuName;
                }
                return Json(new { data = perms, success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "ListCriteriaPermissionByUser");
                return Json(new { data = ex.Message, success = false });
            }
        }
        [Authorize]
        public IActionResult SaveCriteriaPermissionByUser(CriteriaPermissionModel perm)
        {
            var currentUser = httpContextAccessor.HttpContext.User.Identity.Name;
            try
            {
                return Json(new { data = pr.SaveCriteriaPermissionByUser(perm.permissions, perm.Key, currentUser), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "SaveCriteriaPermissionByUser");
                return Json(new { data = ex.Message, success = false });
            }
        }
        [Authorize]
        public IActionResult ListCriteriaPermissionByRole(string key)
        {
            try
            {
                var menus = pr.GetMenu();
                var perms = pr.ListCriteriaPermissionByRole(key).OrderBy(c => c.MenuCode).ThenBy(c => c.CriteriaName);
                foreach (var perm in perms)
                {
                    perm.MenuDisplay = menus.FirstOrDefault(c => c.MenuCode == perm.MenuCode)?.MenuName;
                }
                return Json(new { data = perms, success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "ListCriteriaPermissionByRole");
                return Json(new { data = ex.Message, success = false });
            }
        }
        [Authorize]
        public IActionResult SaveCriteriaPermissionByRole(CriteriaPermissionModel perm)
        {
            var currentUser = httpContextAccessor.HttpContext.User.Identity.Name;
            try
            {
                return Json(new { data = pr.SaveCriteriaPermissionByRole(perm.permissions, perm.Key, currentUser), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "SaveCriteriaPermissionByRole");
                return Json(new { data = ex.Message, success = false });
            }
        }
        [Authorize]
        public IActionResult GetScreens(string criteria)
        {
            var currentUser = httpContextAccessor.HttpContext.User.Identity.Name;
            try
            {
                return Json(new { data = ss.GetScreens(), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "GetScreens");
                return Json(new { data = ex.Message, success = false });
            }
        }
        [Authorize]
        public async Task<IActionResult> IsPasswordExpire()
        {
            var currentUser = httpContextAccessor.HttpContext.User.Identity.Name;
            try
            {
                return Json(new { data = await ss.IsPasswordExpire(currentUser), success = true });
            }
            catch (Exception ex)
            {
                logger.Error(ex, "IsPasswordExpire");
                return Json(new { data = ex.Message, success = false });
            }
        }
    }
}
