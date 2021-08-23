using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SCG.ARS.BOI.WEB.Security.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Security.Repository
{
    public class PermissionRepository : IPermissionRepository
    {
        private SecurityDbContext db;
        public PermissionRepository(SecurityDbContext db)
        {
            this.db = db;
        }
        public List<CriteriaConfig> ListCriteriaConfig(string criteria)
        {
            return db.ars_tbm_CriteriaConfig.Where(c => criteria == null || c.CriteriaName.Contains(criteria)).ToList();
        }
        public int RecordPasswords(string username, string password, string currentUsername)
        {
            if (db.ars_tbl_PasswordHistory.Where(c => c.Username == username).Count() >= 4)
            {
                var user = db.ars_tbl_PasswordHistory.Where(c => c.Username == username).OrderBy(c => c.CreatedDate).FirstOrDefault();
                db.ars_tbl_PasswordHistory.Remove(user);
            }
            var pass = new PasswordHistory
            {
                Username = username,
                Password = password.ToHash(),
                CreatedBy = currentUsername,
                CreatedDate = DateTime.Now,
                UpdatedBy = currentUsername,
                UpdatedDate = DateTime.Now
            };
            return db.SaveChanges();
        }
        public List<PasswordHistory> GetPasswords(string username)
        {
            return db.ars_tbl_PasswordHistory.Where(c => c.Username == username).ToList();
        }
        public List<UserCriteriaPermissionWithDisplay> ListCriteriaPermissionByUser(string username)
        {
            var result = db.ars_tbs_UserCriteriaPermission.Where(c => c.Username == username)
                .Select(c => new UserCriteriaPermissionWithDisplay(c)).ToList();

            return result;
        }
        public List<UserCriteriaPermissionWithDisplay> ListCriteriaPermissionByUser(string username, string route)
        {
            var criNames = db.ars_tbm_CriteriaConfig.Where(c => c.DataRoute == route);
            var result = db.ars_tbs_UserCriteriaPermission.Where(c => c.Username == username && criNames.Any(f => f.CriteriaName == c.CriteriaName))
                .Select(c => new UserCriteriaPermissionWithDisplay(c)).ToList();
            return result;
        }
        public int SaveCriteriaPermissionByUser(List<CriteriaPermissionDetailModel> criteria, string username, string currentUsername)
        {
            //delete
            var deletes = db.ars_tbs_UserCriteriaPermission.Where(c => !criteria.Any(f => f.Id == c.Id) && c.Username == username);
            if (deletes.Count() > 0)
                db.ars_tbs_UserCriteriaPermission.RemoveRange(deletes);

            //insert
            foreach (var rec in criteria.Where(c => !c.Id.HasValue))
            {
                var perm = new UserCriteriaPermission
                {
                    Id = rec.Id ?? 0,
                    Username = username,
                    MenuCode = rec.MenuCode,
                    CriteriaName = rec.CriteriaName,
                    CriteriaDisplay = rec.CriteriaDisplay,
                    CriteriaValue = rec.CriteriaValue,
                    CreatedBy = currentUsername,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = currentUsername,
                    UpdatedDate = DateTime.Now
                };
                db.ars_tbs_UserCriteriaPermission.Add(perm);
            }
            return db.SaveChanges();
        }
        public List<RoleCriteriaPermissionWithDisplay> ListCriteriaPermissionByRole(string roleName)
        {
            return db.ars_tbs_RoleCriteriaPermission.Where(c => c.RoleName == roleName)
                .Select(c => new RoleCriteriaPermissionWithDisplay(c)).ToList();
        }
        public List<RoleCriteriaPermissionWithDisplay> ListCriteriaPermissionByRole(string roleName, string route)
        {
            var criNames = db.ars_tbm_CriteriaConfig.Where(c => c.DataRoute == route);
            return db.ars_tbs_RoleCriteriaPermission.Where(c => c.RoleName == roleName && criNames.Any(f => f.CriteriaName == c.CriteriaName))
                .Select(c => new RoleCriteriaPermissionWithDisplay(c)).ToList();
        }

        public int SaveCriteriaPermissionByRole(List<CriteriaPermissionDetailModel> criteria, string roleName, string currentUsername)
        {
            //delete
            var deletes = db.ars_tbs_RoleCriteriaPermission.Where(c => !criteria.Any(f => f.Id == c.Id) && c.RoleName == roleName);
            if (deletes.Count() > 0)
                db.ars_tbs_RoleCriteriaPermission.RemoveRange(deletes);

            //insert
            foreach (var rec in criteria.Where(c => !c.Id.HasValue))
            {
                var perm = new RoleCriteriaPermission
                {
                    Id = rec.Id ?? 0,
                    RoleName = roleName,
                    MenuCode = rec.MenuCode,
                    CriteriaName = rec.CriteriaName,
                    CriteriaDisplay = rec.CriteriaDisplay,
                    CriteriaValue = rec.CriteriaValue,
                    CreatedBy = currentUsername,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = currentUsername,
                    UpdatedDate = DateTime.Now
                };
                db.ars_tbs_RoleCriteriaPermission.Add(perm);
            }
            return db.SaveChanges();
        }

        public List<ExternalAccess> SearchExternalAccess(string keyword)
        {
            return db.ars_tbs_ExternalAccess.Where(c => string.IsNullOrEmpty(keyword) || c.SourceSystem.Contains(keyword)).OrderBy(c => c.SourceSystem).ToList();
        }

        public ExternalAccess GenerateExternalAccess(string sourceSystem, string username)
        {
            var rng = RNGCryptoServiceProvider.Create();
            string base64Secret;
            do
            {
                var key = new byte[32];
                rng.GetBytes(key);
                base64Secret = Convert.ToBase64String(key);
            }
            while (db.ars_tbs_ExternalAccess.Any(c => c.SecretKey == base64Secret));
            ExternalAccess ea = new ExternalAccess();
            ea.SourceSystem = sourceSystem;
            ea.SecretKey = base64Secret;
            ea.Issuer = "SCG.ARS";
            ea.Audience = "Everyone";
            ea.CreatedBy = username;
            ea.CreatedDate = DateTime.Now;
            ea.UpdatedBy = username;
            ea.UpdatedDate = DateTime.Now;
            db.ars_tbs_ExternalAccess.Add(ea);
            if (db.SaveChanges() == 1)
                return ea;
            else
                return null;
        }

        public int DeleteExternalAccess(string sourceSystem, string username)
        {
            var ea = db.ars_tbs_ExternalAccess.FirstOrDefault(c => c.SourceSystem == sourceSystem);
            if (ea != null)
                db.ars_tbs_ExternalAccess.Remove(ea);
            return db.SaveChanges();
        }

        public ExternalAccess GetExternalAccess(string sourceSystem)
        {
            return db.ars_tbs_ExternalAccess.SingleOrDefault(c => c.SourceSystem == sourceSystem);
        }

        public List<ScreenPermissionModel> GetScreenPermission()
        {
            return db.ars_tbs_ScreenPermission.Select(c => new ScreenPermissionModel
            {
                MenuID = c.menu_id,
                Permission = c.Permission,
            }).ToList();
        }

        public List<SearchCriteria> ListCriteria(SearchCriteriaModel criteria)
        {
            return db.ars_tbl_SearchCriteria.Where(c => c.Username == criteria.Username && c.ScreenID == criteria.ScreenID).OrderBy(c => c.CreatedDate).ToList();
        }

        public SearchCriteria GetDefaultCriteria(SearchCriteriaModel criteria)
        {
            return db.ars_tbl_SearchCriteria.Where(c => c.Username == criteria.Username && c.ScreenID == criteria.ScreenID && c.DefaultCriteria).FirstOrDefault();
        }

        public int SetDefaultCriteria(SearchCriteriaModel criteria)
        {
            var all = db.ars_tbl_SearchCriteria.Where(c => c.Username == criteria.Username && c.ScreenID == criteria.ScreenID).OrderBy(c => c.CreatedDate);
            foreach (var rec in all)
            {
                rec.DefaultCriteria = criteria.Index == rec.Index;
                rec.UpdatedBy = criteria.Username;
                rec.UpdatedDate = DateTime.Now;
            }
            return db.SaveChanges();
        }

        public int DeleteCriteria(SearchCriteriaModel criteria)
        {
            if (db.ars_tbl_SearchCriteria.Any(c => c.ScreenID == criteria.ScreenID && c.Index == criteria.Index && c.Username == criteria.Username))
                db.ars_tbl_SearchCriteria.RemoveRange(db.ars_tbl_SearchCriteria.Where(c => c.ScreenID == criteria.ScreenID && c.Index == criteria.Index && c.Username == criteria.Username));
            db.SaveChanges();
            var all = db.ars_tbl_SearchCriteria.Where(c => c.Username == criteria.Username && c.ScreenID == criteria.ScreenID).OrderBy(c => c.CreatedDate);
            foreach (var rec in all)
            {
                rec.UpdatedBy = criteria.Username;
                rec.UpdatedDate = DateTime.Now;
            }
            return db.SaveChanges();
        }

        public int SaveCriteria(List<SearchCriteriaModel> criteria, string username)
        {
            if (criteria.Count > 0) {
                if (db.ars_tbl_SearchCriteria.Any(c => criteria.Any(w => c.ScreenID == w.ScreenID && c.Index == w.Index && c.Username == username)))
                    db.ars_tbl_SearchCriteria.RemoveRange(db.ars_tbl_SearchCriteria.Where(c => criteria.Any(w => c.ScreenID == w.ScreenID && c.Username == username)));
            }

            db.ars_tbl_SearchCriteria.AddRange(criteria.Select(c => new SearchCriteria
            {
                ScreenID = c.ScreenID,
                Index = c.Index,
                Username = username,
                CriteriaName = c.CriteriaName,
                Criteria = c.Criteria,
                CreatedBy = username,
                DefaultCriteria = c.DefaultCriteria,
                CreatedDate = (c.CreatedDate ?? DateTime.Now),
                UpdatedBy = username,
                UpdatedDate = DateTime.Now
            }));
            return db.SaveChanges();
        }

        public List<ScreenModel> GetMenu()
        {
            var conn = db.Database.GetDbConnection();
            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();
            using var cmd = conn.CreateCommand();
            cmd.CommandText =
@"With RECURSIVE mnu as (
	SELECT 	menu_id, parent_id, menu_code, menu_name, menu_path menu_route, 
            menu_icon, menu_order, 1 depth, 
            LPad(menu_order::text, 3, '0') || menu_code::text order_path, 
            menu_name::text menu_path
	FROM 	master.ars_tbl_menu
	Where	parent_id is null
			And is_active = true
	Union all
	Select  mn.menu_id, mn.parent_id, mn.menu_code, mn.menu_name, mn.menu_path menu_route,
            mn.menu_icon, mn.menu_order, mnu.depth + 1 depth, 
            mnu.order_path || LPad(mn.menu_order::text, 3, '0')::text || mn.menu_code order_path, 
            mnu.menu_path || ' > ' || mn.menu_name  menu_path
	From	master.ars_tbl_menu mn
			Inner join mnu 
			On mn.parent_id = mnu.menu_id
	Where	mn.is_active = true
)
Select  mnu.menu_id, mnu.parent_id, mnu.menu_code, mnu.menu_name, 
        mnu.menu_route, mnu.menu_icon, mnu.menu_order, mnu.depth, 
        mnu.menu_path, order_path
From	mnu
Order by
		mnu.order_path";
            cmd.CommandType = System.Data.CommandType.Text;
            using var reader = cmd.ExecuteReader();
            List<ScreenModel> screens = new List<ScreenModel>();
            while(reader.Read())
            {
                screens.Add(new ScreenModel
                {
                    MenuID = reader.GetInt32(0),
                    ParentID = ToInt32(reader, 1),
                    MenuCode = ToString(reader, 2),
                    MenuName = ToString(reader, 3),
                    MenuRoute = ToString(reader, 4),
                    MenuIcon = ToString(reader, 5),
                    Order = reader.GetInt32(6),
                    Depth = reader.GetInt32(7),
                    MenuPath = ToString(reader, 8),
                    OrderPath = ToString(reader, 9),
                });
            }
            return screens;
        }

        private int? ToInt32(DbDataReader reader, int ordinal)
        {
            if (reader.IsDBNull(ordinal))
                return null;
            else
                return reader.GetInt32(ordinal);
        }

        private string ToString(DbDataReader reader, int ordinal)
        {
            if (reader.IsDBNull(ordinal))
                return null;
            else
                return reader.GetString(ordinal);
        }
        public bool ValidateCookieToken(string username, string token)
        {
            return db.ars_tbs_CookieToken.Any(c => c.Username == username && c.CookieToken == token);
        }
        public int RecordCookieToken(string username, string token)
        {
            var rec = db.ars_tbs_CookieToken.FirstOrDefault(c => c.Username == username);
            if (rec == null)
            {
                rec = new CookieTokenModel
                {
                    Username = username,
                };
                db.ars_tbs_CookieToken.Add(rec);
            }
            rec.CookieToken = token;
            rec.CreatedDate = DateTime.Now;
            return db.SaveChanges();
        }
    }
}
