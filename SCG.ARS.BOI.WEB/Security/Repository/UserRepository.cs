using SCG.ARS.BOI.WEB.Security.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Security.Repository
{
    public class UserRepository : IUserRepository
    {
        private SecurityDbContext db;
        public UserRepository(SecurityDbContext db)
        {
            this.db = db;
        }

        public int Delete(ApplicationUser user, string pic)
        {
            var userToUpdate = db.ars_tbs_User.FirstOrDefault(c => c.UserName == user.UserName);
            if (userToUpdate != null)
            {
                userToUpdate.IsDelete = true;
                userToUpdate.UpdatedBy = pic;
                userToUpdate.UpdatedDate = DateTime.Now;
            }
            return db.SaveChanges();
        }

        public int Restore(ApplicationUser user, string pic)
        {
            var userToUpdate = db.ars_tbs_User.FirstOrDefault(c => c.UserName == user.UserName);
            if (userToUpdate != null)
            {
                userToUpdate.IsDelete = false;
                userToUpdate.UpdatedBy = pic;
                userToUpdate.UpdatedDate = DateTime.Now;
            }
            return db.SaveChanges();
        }

        public IQueryable<ApplicationUser> Find(string keyword)
        {
            return db.ars_tbs_User.Where(c => string.IsNullOrEmpty(keyword) || c.UserName.Contains(keyword) || c.FullName.Contains(keyword) || c.Email.Contains(keyword));
        }

        public int AddClaim(ApplicationUser user, Claim claim, string pic)
        {
            if (!db.ars_tbs_UserClaim.Any(c => c.ClaimType == claim.Type && 
                c.ClaimValue == claim.Value && 
                c.UserId == user.Id))
            {
                var auc = new ApplicationUserClaim()
                {
                    UserId = user.Id,
                    ClaimType = claim.Type,
                    ClaimValue = claim.Value,
                    CreatedBy = pic,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = pic,
                    UpdatedDate = DateTime.Now,
                };
                db.ars_tbs_UserClaim.Add(auc);
            }
            return db.SaveChanges();
        }

        public int RemoveClaim(ApplicationUser user, Claim claim, string pic)
        {
            var auc = db.ars_tbs_UserClaim.FirstOrDefault(c => c.ClaimType == claim.Type && 
                c.ClaimValue == claim.Value && 
                c.UserId == user.Id);
            if (auc != null)
            {
                db.ars_tbs_UserClaim.Remove(auc);
            }
            return db.SaveChanges();
        }

        public int AddRole(ApplicationUser user, string roleName, string pic)
        {
            var role = db.ars_tbs_Role.FirstOrDefault(c => c.Name == roleName);
            if (role == null)
                return -1;
            if (!db.ars_tbs_UserRole.Any(c => c.RoleId == role.Id &&
                c.UserId == user.Id))
            {
                var aur = new ApplicationUserRole()
                {
                    UserId = user.Id,
                    RoleId = role.Id,
                    CreatedBy = pic,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = pic,
                    UpdatedDate = DateTime.Now,
                };
                db.ars_tbs_UserRole.Add(aur);
            }
            else
            {
                return -2;
            }
            return db.SaveChanges();
        }

        public int RemoveRole(ApplicationUser user, string roleName, string pic)
        {
            var role = db.ars_tbs_Role.FirstOrDefault(c => c.Name == roleName);
            var aur = db.ars_tbs_UserRole.FirstOrDefault(c => c.RoleId == role.Id && 
                c.UserId == user.Id);
            if (aur != null)
            {
                db.ars_tbs_UserRole.Remove(aur);
            }
            return db.SaveChanges();
        }
    }
}
