namespace SCG.ARS.BOI.WEB.Services
{
    using System.Security.Claims;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models;

    public interface IUserService
    {
        string GenerateMenu();
        Users GetUsers(ClaimsPrincipal user);
        Users GetUser(string userCode);
        Admins GetAdmin(ClaimsPrincipal user);
        Admins GetAdmin(string userCode);
        Menus GetMenu(string menuCode);
        List<Menus> GetMenus(int userGroupId);
        Task<(bool, Users)> ValidateUserCredentialsAsync(string username, string password);
        List<LinkRolesMenus> GetPermissions(ClaimsPrincipal user, string menuCode);
    }
}