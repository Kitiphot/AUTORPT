using SCG.ARS.BOI.WEB.Security.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Security.Repository
{
    public class RoleRepository : IRoleRepository
    {
        private SecurityDbContext db;
        public RoleRepository(SecurityDbContext db)
        {
            this.db = db;
        }

        public int AddClaim(ApplicationRole role, Claim claim, string pic)
        {
            if (!db.ars_tbs_RoleClaim.Any(c => c.ClaimType == claim.Type &&
                c.ClaimValue == claim.Value &&
                c.RoleId == role.Id))
            {
                var arc = new ApplicationRoleClaim()
                {
                    RoleId = role.Id,
                    ClaimType = claim.Type,
                    ClaimValue = claim.Value,
                    CreatedBy = pic,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = pic,
                    UpdatedDate = DateTime.Now,
                };
                db.ars_tbs_RoleClaim.Add(arc);
            }
            return db.SaveChanges();
        }

        public int Delete(ApplicationRole role, string pic)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ApplicationRole> Find(string keyword)
        {
            return db.ars_tbs_Role.Where(c => string.IsNullOrEmpty(keyword) || c.Name.Contains(keyword) || c.Category.Contains(keyword));
        }

        public int RemoveClaim(ApplicationRole role, Claim claim, string pic)
        {
            if (db.ars_tbs_RoleClaim.Any(c => c.ClaimType == claim.Type &&
                c.ClaimValue == claim.Value &&
                c.RoleId == role.Id))
            {
                var claimRec = db.ars_tbs_RoleClaim.FirstOrDefault(c => c.ClaimType == claim.Type &&
                    c.ClaimValue == claim.Value &&
                    c.RoleId == role.Id);
                db.ars_tbs_RoleClaim.Remove(claimRec);
            }
            return db.SaveChanges();
        }
    }
}
