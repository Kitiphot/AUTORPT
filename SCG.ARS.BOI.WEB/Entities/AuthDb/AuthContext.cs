using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SCG.ARS.BOI.WEB.Entities.AuthDb
{
    public partial class AuthContext : DbContext
    {
        public AuthContext()
        {
        }

        public AuthContext(DbContextOptions<AuthContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ArsTblPage> ArsTblPage { get; set; }
        public virtual DbSet<ArsTblPermission> ArsTblPermission { get; set; }
        public virtual DbSet<ArsTblRole> ArsTblRole { get; set; }
        public virtual DbSet<ArsTblRoleUsers> ArsTblRoleUsers { get; set; }
        public virtual DbSet<ArsTblUser> ArsTblUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=auto-report-pg.ctg0nvlybzpq.ap-southeast-1.rds.amazonaws.com; Username =csi_all; Password =CSI_@ll; Database =qa_autoreport", x => x.UseNodaTime());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<ArsTblPage>(entity =>
            {
                entity.HasKey(e => e.Pageid)
                    .HasName("ars_tbl_page_pkey");

                entity.ToTable("ars_tbl_page", "auth");

                entity.Property(e => e.Pageid)
                    .HasColumnName("pageid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Pagecontroller)
                    .IsRequired()
                    .HasColumnName("pagecontroller")
                    .HasColumnType("character(100)");

                entity.Property(e => e.Pagename)
                    .IsRequired()
                    .HasColumnName("pagename")
                    .HasColumnType("character(50)");
            });

            modelBuilder.Entity<ArsTblPermission>(entity =>
            {
                entity.HasKey(e => e.Permissionid)
                    .HasName("ars_tbl_permission_pkey");

                entity.ToTable("ars_tbl_permission", "auth");

                entity.Property(e => e.Permissionid)
                    .HasColumnName("permissionid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Permissionname)
                    .IsRequired()
                    .HasColumnName("permissionname")
                    .HasColumnType("character(40)");
            });

            modelBuilder.Entity<ArsTblRole>(entity =>
            {
                entity.HasKey(e => e.Roleid)
                    .HasName("ars_tbl_role_pkey");

                entity.ToTable("ars_tbl_role", "auth");

                entity.Property(e => e.Roleid)
                    .HasColumnName("roleid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Rolename)
                    .IsRequired()
                    .HasColumnName("rolename")
                    .HasColumnType("character(40)");
            });

            modelBuilder.Entity<ArsTblRoleUsers>(entity =>
            {
                entity.HasKey(e => e.Roleuserid)
                    .HasName("ars_tbl_role_users_pkey");

                entity.ToTable("ars_tbl_role_users", "auth");

                entity.Property(e => e.Roleuserid)
                    .HasColumnName("roleuserid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Roleid).HasColumnName("roleid");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ArsTblUser>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("ars_tbl_user_pkey");

                entity.ToTable("ars_tbl_user", "auth");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Emailaddress)
                    .IsRequired()
                    .HasColumnName("emailaddress")
                    .HasColumnType("character(40)");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasColumnType("character(40)");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasColumnType("character(40)");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("character(20)");
            });
        }
    }
}
