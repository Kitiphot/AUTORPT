using Microsoft.AspNetCore.Http;
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
    public interface ISecurityService
    {
        int IsAllow(ScreenID screen, Permission perm);
        bool isLogin();
        string GetUsername();
        Task<string> GetFullname();
        string GetAdminUser();
        string GetAdminRole();
        Task<List<MiscDataSelectionModel>> GetAllowData(HttpContext _context, RouteData routeData, string criteria = null);
        Task<List<MiscDataSelectionModel>> GetAllowData(HttpContext _context, string route, string criteria = null);
        List<MiscDataSelectionModel> GetScreens();
        Task<PasswordValidateResult> ValidatePassword(string password, string username);
        Task<bool> IsPasswordExpire(string username);
    }
}
