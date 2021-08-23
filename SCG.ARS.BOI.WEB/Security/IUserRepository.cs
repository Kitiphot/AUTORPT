using SCG.ARS.BOI.WEB.Security.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Security
{
    public interface IUserRepository
    {

        int Delete(ApplicationUser user, string pic);
        int Restore(ApplicationUser user, string pic);

        IQueryable<ApplicationUser> Find(string keyword);

        int AddClaim(ApplicationUser user, Claim claim, string pic);

        int RemoveClaim(ApplicationUser user, Claim claim, string pic);

        int AddRole(ApplicationUser user, string roleName, string pic);

        int RemoveRole(ApplicationUser user, string roleName, string pic);
    }
}
