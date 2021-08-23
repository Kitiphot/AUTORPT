using SCG.ARS.BOI.WEB.Security.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Security
{
    public interface IPermissionRepository
    {
        List<PasswordHistory> GetPasswords(string username);
        int RecordPasswords(string username, string password, string currentUsername);
        List<CriteriaConfig> ListCriteriaConfig(string criteria);
        List<UserCriteriaPermissionWithDisplay> ListCriteriaPermissionByUser(string username);
        List<UserCriteriaPermissionWithDisplay> ListCriteriaPermissionByUser(string username, string route);
        int SaveCriteriaPermissionByUser(List<CriteriaPermissionDetailModel> criteria, string username, string currentUsername);
        List<RoleCriteriaPermissionWithDisplay> ListCriteriaPermissionByRole(string roleName);
        List<RoleCriteriaPermissionWithDisplay> ListCriteriaPermissionByRole(string roleName, string route);
        int SaveCriteriaPermissionByRole(List<CriteriaPermissionDetailModel> criteria, string roleName, string currentUsername);

        List<ExternalAccess> SearchExternalAccess(string keyword);
        ExternalAccess GenerateExternalAccess(string sourceSystem, string username);
        int DeleteExternalAccess(string sourceSystem, string username);
        ExternalAccess GetExternalAccess(string sourceSystem);
        List<ScreenPermissionModel> GetScreenPermission();
        List<ScreenModel> GetMenu();
        List<SearchCriteria> ListCriteria(SearchCriteriaModel criteria);
        SearchCriteria GetDefaultCriteria(SearchCriteriaModel criteria);
        int SaveCriteria(List<SearchCriteriaModel> criteria, string username);
        int SetDefaultCriteria(SearchCriteriaModel criteria);
        int DeleteCriteria(SearchCriteriaModel criteria);
        bool ValidateCookieToken(string username, string token);
        int RecordCookieToken(string username, string token);
    }
}
