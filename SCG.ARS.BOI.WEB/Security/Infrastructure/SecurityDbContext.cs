using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SCG.ARS.BOI.WEB.Attributes;
using SCG.ARS.BOI.WEB.Security.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Security
{
    public class SecurityDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, 
        string, ApplicationUserClaim, ApplicationUserRole, IdentityUserLogin<string>, 
        ApplicationRoleClaim, IdentityUserToken<string>>
    {
        public SecurityDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("master");
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>()
                .ToTable("ars_tbs_User")
                .Property(c => c.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<ApplicationRole>()
                .ToTable("ars_tbs_Role")
                .Property(c => c.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<ApplicationRoleClaim>()
                .ToTable("ars_tbs_RoleClaim")
                .Property(c => c.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<ApplicationUserClaim>()
                .ToTable("ars_tbs_UserClaim")
                .Property(c => c.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<CriteriaConfig>()
                .ToTable("ars_tbm_CriteriaConfig")
                .Property(c => c.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<UserCriteriaPermission>()
                .ToTable("ars_tbs_UserCriteriaPermission")
                .Property(c => c.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<RoleCriteriaPermission>()
                .ToTable("ars_tbs_RoleCriteriaPermission")
                .Property(c => c.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<CookieTokenModel>()
                .ToTable("ars_tbs_CookieToken")
                .HasKey(c => c.Username); ;

            modelBuilder.Entity<IdentityUserLogin<string>>()
                .ToTable("ars_tbs_UserLogin");

            modelBuilder.Entity<ApplicationUserRole>()
                .ToTable("ars_tbs_UserRole");

            modelBuilder.Entity<IdentityUserToken<string>>()
                .ToTable("ars_tbs_UserToken");

            modelBuilder.Entity<ExternalAccess>()
                .ToTable("ars_tbs_ExternalAccess");

            modelBuilder.Entity<SearchCriteria>()
                .ToTable("ars_tbl_SearchCriteria");

            modelBuilder.Entity<CriteriaConfig>()
                .ToTable("ars_tbm_CriteriaConfig");

            modelBuilder.Entity<UserCriteriaPermission>()
                .ToTable("ars_tbs_UserCriteriaPermission");

            modelBuilder.Entity<RoleCriteriaPermission>()
                .ToTable("ars_tbs_RoleCriteriaPermission");

            modelBuilder.Entity<PasswordHistory>()
                .ToTable("ars_tbl_PasswordHistory");

            modelBuilder.Entity<ApplicationUser>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<ApplicationRole>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<ApplicationRoleClaim>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<ApplicationUserClaim>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<CriteriaConfig>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<UserCriteriaPermission>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<ScreenPermission>()
                .HasKey(c => new { c.menu_id, c.Permission });
            modelBuilder.Entity<ExternalAccess>()
                .HasKey(c => c.SourceSystem);
            modelBuilder.Entity<SearchCriteria>()
                .HasKey(c => new { c.ScreenID, c.Index, c.Username });
            modelBuilder.Entity<PasswordHistory>()
                .HasKey(c => new { c.Username, c.Password });

            //modelBuilder.Entity<IdentityUserLogin<string>>()
            //    .HasKey(c => new { c.LoginProvider, c.ProviderKey, c.UserId });
            modelBuilder.Entity<ApplicationUserRole>()
                .HasKey(c => new { c.UserId, c.RoleId });

            string adminID = Guid.NewGuid().ToString();
            string adminRoleID = Guid.NewGuid().ToString();
            modelBuilder.Entity<ApplicationUser>()
                .HasData(new ApplicationUser[] {
                    new ApplicationUser { Id=adminID, Email = "admin@something.com", NormalizedEmail= "ADMIN@SOMETHING.COM", UserName = "admin", NormalizedUserName = "ADMIN", SecurityStamp="3DGJHAJOGWNPPDENE2ILFGFLGBSHE2XE", ConcurrencyStamp=Guid.NewGuid().ToString(), PasswordHash="AQAAAAEAACcQAAAAEGPfnaFL/mUvI4TbVDRUtC4lN7WfkpLubGDuMkU7YIVeAM40c+mOqKwGyy/5OJ2UUA==", CreatedBy="Initial", CreatedDate=DateTime.Now, UpdatedBy="Initial", UpdatedDate=DateTime.Now, IsDelete=false, FullName="Administrator", FirstName="System", LastName="Administrator", MustChangePassword=false, LastChangePasswordDate= null, CustomerCode=null }
                });

            modelBuilder.Entity<ApplicationRole>().HasData(new ApplicationRole[] {
                new ApplicationRole("Administrator") { Id = adminRoleID, CreatedBy = "Initial", CreatedDate = DateTime.Now, UpdatedBy = "Initial", UpdatedDate = DateTime.Now }
            });

            //int id = 1;
            //List<ApplicationUserClaim> userClaims = new List<ApplicationUserClaim>();
            //foreach (var screen in Enum.GetNames(typeof(ScreenID)))
            //    userClaims.Add(new ApplicationUserClaim { Id = id++, UserId = adminID, ClaimType = $"PM_{Permission.View.ToString()}", ClaimValue = screen, CreatedBy = "Initial", CreatedDate = DateTime.Now, UpdatedBy = "Initial", UpdatedDate = DateTime.Now });
            //modelBuilder.Entity<ApplicationUserClaim>().HasData(userClaims);

            modelBuilder.Entity<ApplicationUserRole>().HasData(new ApplicationUserRole[] {
                new ApplicationUserRole { RoleId = adminRoleID, UserId = adminID, CreatedBy = "Initial", CreatedDate = DateTime.Now, UpdatedBy = "Initial", UpdatedDate = DateTime.Now }
            });
        }
        public DbSet<ApplicationUser> ars_tbs_User { get; set; }
        public DbSet<ApplicationRole> ars_tbs_Role { get; set; }
        public DbSet<ApplicationRoleClaim> ars_tbs_RoleClaim { get; set; }
        public DbSet<ApplicationUserClaim> ars_tbs_UserClaim { get; set; }
        public DbSet<IdentityUserLogin<string>> ars_tbs_UserLogin { get; set; }
        public DbSet<ApplicationUserRole> ars_tbs_UserRole { get; set; }
        public DbSet<IdentityUserToken<string>> ars_tbs_UserToken{ get; set; }
        public DbSet<ScreenPermission> ars_tbs_ScreenPermission { get; set; }
        public DbSet<ExternalAccess> ars_tbs_ExternalAccess { get; set; }
        public DbSet<SearchCriteria> ars_tbl_SearchCriteria { get; set; }
        public DbSet<CriteriaConfig> ars_tbm_CriteriaConfig { get; set; }
        public DbSet<UserCriteriaPermission> ars_tbs_UserCriteriaPermission { get; set; }
        public DbSet<RoleCriteriaPermission> ars_tbs_RoleCriteriaPermission { get; set; }
        public DbSet<PasswordHistory> ars_tbl_PasswordHistory { get; set; }
        public DbSet<CookieTokenModel> ars_tbs_CookieToken { get; set; }
    }
}
