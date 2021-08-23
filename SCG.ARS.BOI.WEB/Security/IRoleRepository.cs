using SCG.ARS.BOI.WEB.Security.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Security
{
    public interface IRoleRepository
    {

        int Delete(ApplicationRole role, string pic);

        IQueryable<ApplicationRole> Find(string keyword);

        int AddClaim(ApplicationRole role, Claim claim, string pic);

        int RemoveClaim(ApplicationRole role, Claim claim, string pic);
    }
}
