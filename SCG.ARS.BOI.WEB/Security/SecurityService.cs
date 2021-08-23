using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
using SCG.ARS.BOI.WEB.Attributes;
using SCG.ARS.BOI.WEB.Models;
using SCG.ARS.BOI.WEB.Security.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Security
{
    public class SecurityService : ISecurityService
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly UserManager<ApplicationUser> usrMngr;
        private readonly IUserRepository ur;
        private readonly IPermissionRepository pr;
        public SecurityService(
            IHttpContextAccessor httpContextAccessor,
            UserManager<ApplicationUser> usrMngr,
            IUserRepository ur,
            IPermissionRepository pr)
        {
            this.httpContextAccessor = httpContextAccessor;
            this.usrMngr = usrMngr;
            this.pr = pr;
            this.ur = ur;
        }
        public int IsAllow(ScreenID screen, Permission perm)
        {
            return httpContextAccessor.HttpContext.User.IsAllow(screen, perm) ? 1 : 0;
        }
        public string GetUsername()
        {
            return httpContextAccessor.HttpContext.User.Identity.Name;
        }
        public async Task<string> GetFullname()
        {
            try
            {
                var usr = await usrMngr.FindByNameAsync(httpContextAccessor.HttpContext.User.Identity.Name);
                return $"{usr.FirstName} {usr.LastName}";
            }
            catch
            {
            }
            return "Anonymous";
        }
        public bool isLogin()
        {
            return httpContextAccessor.HttpContext.User.Identity.IsAuthenticated;
        }
        public string GetAdminUser()
        {
            return SecurityHelpers.GetAdminUser();
        }
        public string GetAdminRole()
        {
            return SecurityHelpers.GetAdminRole();
        }
        public async Task<List<MiscDataSelectionModel>> GetAllowData(HttpContext _context, string route, string criteria = null)
        {
            Microsoft.AspNetCore.Http.Headers.RequestHeaders header = _context.Request.GetTypedHeaders();
            Uri uriReferer = header.Referer;
            string screenCode = uriReferer.ToString();
            screenCode = screenCode.Substring(screenCode.LastIndexOf("/") + 1);
            var user = await usrMngr.GetUserAsync(_context.User);
            var roles = await usrMngr.GetRolesAsync(user);

            var allCriteria = pr.ListCriteriaConfig(null).Where(c => criteria == null || c.DataCriteria == criteria).Select(c => c.CriteriaName);

            //ignore data filter if open from security screen...
            if (!uriReferer.ToString().Contains("/Security", StringComparison.InvariantCultureIgnoreCase))
            {

                List<MiscDataSelectionModel> data = pr.ListCriteriaPermissionByUser(_context.User.Identity.Name, route)
                    .Where(c => c.MenuCode == null || (c.MenuCode != null && c.MenuCode == screenCode))
                    .Where(c => allCriteria.Contains(c.CriteriaName))
                    .Select(c => new MiscDataSelectionModel
                    {
                        DataDisplay = c.CriteriaDisplay,
                        DataValue_Key = c.CriteriaValue
                    }).ToList();

                foreach (var role in roles)
                {
                    data.AddRange(pr.ListCriteriaPermissionByRole(role, route)
                        .Where(c => c.MenuCode == null || (c.MenuCode != null && c.MenuCode == screenCode))
                    .Where(c => allCriteria.Contains(c.CriteriaName))
                        .Select(c => new MiscDataSelectionModel
                        {
                            DataDisplay = c.CriteriaDisplay,
                            DataValue_Key = c.CriteriaValue
                        }).ToList());
                }
                return data.Distinct().ToList();
            }
            else
            {
                return new List<MiscDataSelectionModel>();
            }
        }
        public async Task<List<MiscDataSelectionModel>> GetAllowData(HttpContext _context, RouteData routeData, string criteria = null)
        {
            string actionName = routeData.Values["action"].ToString();
            string controllerName = routeData.Values["controller"].ToString();
            string route = $"/{controllerName}/{actionName}";

            return await GetAllowData(_context, route, criteria);
        }

        public List<MiscDataSelectionModel> GetScreens()
        {
            var screens = pr.GetMenu().Where(c => !string.IsNullOrEmpty(c.MenuRoute)).Select(c => new MiscDataSelectionModel {
                DataValue_Key = c.MenuCode,
                DataDisplay = c.MenuName
            }).ToList();
            return screens;
        }
        public async Task<PasswordValidateResult> ValidatePassword(string username, string password)
        {
            PasswordValidateResult result = new PasswordValidateResult { IsValid = true, Errors = new List<string>() };
            if (string.IsNullOrEmpty(password))
            {
                result.IsValid = false;
                result.Errors.Add("Password is required.");
            }
            else
            {
                if (password.Length < 8)
                {
                    result.IsValid = false;
                    result.Errors.Add("Password's length is not meet minimum requirement (at least 8 characters).");
                }

                string specialChars = @" !""#$%&'()*+,-./:;<=>?@[\]^_`{|}~";
                int securityScore = 0;
                securityScore += password.Any(c => Char.IsUpper(c)) ? 1 : 0;
                securityScore += password.Any(c => Char.IsLower(c)) ? 1 : 0;
                securityScore += password.Any(c => Char.IsDigit(c)) ? 1 : 0;
                securityScore += password.Any(c => specialChars.Contains(c)) ? 1 : 0;

                if (securityScore < 3)
                {
                    result.IsValid = false;
                    result.Errors.Add($"Password must contain at least 3 of below category: " +
                        $"<br/>- lower case<br/>- upper case" +
                        $"<br/>- numerals<br/>- special characters");
                }

                var user = await usrMngr.FindByNameAsync(username);
                if (user != null && password.Length >= 3)
                {
                    List<string> combinations = new List<string>();
                    for (int i = 0; i < password.Length - 2; i++)
                    {
                        combinations.Add(password.Substring(i, 3));
                    }
                    if (combinations.Any(c => user.FullName.Contains(c) || user.UserName.Contains(c)))
                    {
                        result.IsValid = false;
                        result.Errors.Add($"Cannot contain more than 3 consecutive characters that are parts of your Username or your Full name.");
                    }
                }
            }
            if (result.IsValid)
            {
                if (pr.GetPasswords(username).Any(c => c.Password == password.ToHash()))
                {
                    result.IsValid = false;
                    result.Errors.Add($"The password must be difference from the previous 4 passwords");
                }
            }
            return result;
        }

        public async Task<bool> IsPasswordExpire(string username)
        {
            var user = await usrMngr.FindByNameAsync(username);
            if (user != null && user.Domain == "External") {
                var lastChangeDate = user.LastChangePasswordDate ?? user.CreatedDate;
                var tsPass = new TimeSpan(lastChangeDate.Ticks);
                var tsNow = new TimeSpan(DateTime.Now.Ticks);
                if (tsNow.Subtract(tsPass).TotalDays > 90)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
