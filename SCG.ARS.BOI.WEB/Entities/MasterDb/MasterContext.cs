using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SCG.ARS.BOI.WEB.Entities.MasterDb
{
    public partial class MasterContext : DbContext
    {
        public MasterContext()
        {
        }

        public MasterContext(DbContextOptions<MasterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ArsTblColumn> ArsTblColumn { get; set; }
        public virtual DbSet<ArsTblColumnTemplate> ArsTblColumnTemplate { get; set; }
        public virtual DbSet<ArsTblCustomer> ArsTblCustomer { get; set; }
        public virtual DbSet<ArsTblCustomerTemplate> ArsTblCustomerTemplate { get; set; }
        public virtual DbSet<ArsTblDataType> ArsTblDataType { get; set; }
        public virtual DbSet<ArsTblEmailAttachment> ArsTblEmailAttachment { get; set; }
        public virtual DbSet<ArsTblEmailReportMapping> ArsTblEmailReportMapping { get; set; }
        public virtual DbSet<ArsTblEmailScheduler> ArsTblEmailScheduler { get; set; }
        public virtual DbSet<ArsTblEmailSchedulerStatus> ArsTblEmailSchedulerStatus { get; set; }
        public virtual DbSet<ArsTblEmailaddress> ArsTblEmailaddress { get; set; }
        public virtual DbSet<ArsTblFunction> ArsTblFunction { get; set; }
        public virtual DbSet<ArsTblLogs> ArsTblLogs { get; set; }
        public virtual DbSet<ArsTblMenu> ArsTblMenu { get; set; }
        public virtual DbSet<ArsTblParameterSource> ArsTblParameterSource { get; set; }
        public virtual DbSet<ArsTblParameterType> ArsTblParameterType { get; set; }
        public virtual DbSet<ArsTblReport> ArsTblReport { get; set; }
        public virtual DbSet<ArsTblSchema> ArsTblSchema { get; set; }
        public virtual DbSet<ArsTblReportGroup> ArsTblReportGroup { get; set; }
        public virtual DbSet<ArsTblReportGroupMapping> ArsTblReportGroupMapping { get; set; }
        public virtual DbSet<ArsTblTable> ArsTblTable { get; set; }
        public virtual DbSet<ArsTblTemplate> ArsTblTemplate { get; set; }
        public virtual DbSet<ArsTblTemplateColumnMapping> ArsTblTemplateColumnMapping { get; set; }
        public virtual DbSet<ArsTblTemplateParameterMapping> ArsTblTemplateParameterMapping { get; set; }
        public virtual DbSet<ArsTblTemplateReportMapping> ArsTblTemplateReportMapping { get; set; }
        public virtual DbSet<ArsTblTemplateTrigger> ArsTblTemplateTrigger { get; set; }
        
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

            modelBuilder.Entity<ArsTblColumn>(entity =>
            {
                entity.HasKey(e => new { e.Columnid, e.Tableid, e.Schemaid })
                    .HasName("ars_tbl_column_pkey");

                entity.ToTable("ars_tbl_column", "master");

                entity.Property(e => e.Columnid).HasColumnName("columnid");

                entity.Property(e => e.Tableid).HasColumnName("tableid");

                entity.Property(e => e.Schemaid).HasColumnName("schemaid");

                entity.Property(e => e.Columnname)
                    .IsRequired()
                    .HasColumnName("columnname")
                    .HasColumnType("character(40)");

                entity.Property(e => e.Columntype)
                    .IsRequired()
                    .HasColumnName("columntype")
                    .HasColumnType("character(40)");
            });

            modelBuilder.Entity<ArsTblColumnTemplate>(entity =>
            {
                entity.HasKey(e => new { e.TemplateId, e.ColumnId })
                    .HasName("ars_tbl_column_template_pkey");

                entity.ToTable("ars_tbl_column_template", "master");

                entity.Property(e => e.TemplateId).HasColumnName("template_id");

                entity.Property(e => e.ColumnId).HasColumnName("column_id");

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasColumnName("column_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ColumnTypeId).HasColumnName("column_type_id");
            });

            modelBuilder.Entity<ArsTblCustomer>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("ars_tbl_customer_pkey");

                entity.ToTable("ars_tbl_customer", "master");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasColumnName("customer_name")
                    .HasMaxLength(100);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("true");
            });

            modelBuilder.Entity<ArsTblCustomerTemplate>(entity =>
            {
                entity.HasKey(e => new { e.TemplateId, e.CustomerId, e.ReportId })
                    .HasName("ars_tbl_customer_template_pkey");

                entity.ToTable("ars_tbl_customer_template", "master");

                entity.Property(e => e.TemplateId).HasColumnName("template_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.ReportId).HasColumnName("report_id");
            });

            modelBuilder.Entity<ArsTblDataType>(entity =>
            {
                entity.HasKey(e => e.DataTypeId)
                    .HasName("ars_tbl_data_type_pkey");

                entity.ToTable("ars_tbl_data_type", "master");

                entity.Property(e => e.DataTypeId)
                    .HasColumnName("data_type_id")
                    .HasDefaultValueSql("nextval('master.ars_tbl_data_type_data_type_id_seq'::regclass)");

                entity.Property(e => e.DataTypeName)
                    .IsRequired()
                    .HasColumnName("data_type_name")
                    .HasMaxLength(100);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("true");
            });

            modelBuilder.Entity<ArsTblEmailAttachment>(entity =>
            {
                entity.HasKey(e => e.EmailAttachmentId)
                    .HasName("ars_tbl_email_attachment_pkey");

                entity.ToTable("ars_tbl_email_attachment", "master");

                entity.Property(e => e.EmailAttachmentId)
                    .HasColumnName("email_attachment_id")
                    .UseNpgsqlIdentityAlwaysColumn();

                entity.Property(e => e.EmailSchedulerId).HasColumnName("email_scheduler_id");

                entity.Property(e => e.TemplateReportMappingId).HasColumnName("template_report_mapping_id");
            });

            modelBuilder.Entity<ArsTblEmailReportMapping>(entity =>
            {
                entity.HasKey(e => new { e.EmailId, e.TemplateId })
                    .HasName("ars_tbl_email_report_mapping_pkey");

                entity.ToTable("ars_tbl_email_report_mapping", "master");

                entity.Property(e => e.EmailId).HasColumnName("email_id");

                entity.Property(e => e.TemplateId).HasColumnName("template_id");
            });

            modelBuilder.Entity<ArsTblEmailScheduler>(entity =>
            {
                entity.HasKey(e => e.EmailSchedulerId)
                    .HasName("ars_tbl_email_scheduler_pkey");

                entity.ToTable("ars_tbl_email_scheduler", "master");

                entity.Property(e => e.EmailSchedulerId)
                    .HasColumnName("email_scheduler_id")
                    .UseNpgsqlIdentityAlwaysColumn();

                entity.Property(e => e.EmailBcc)
                    .HasColumnName("email_bcc")
                    .HasMaxLength(500);

                entity.Property(e => e.EmailBody).HasColumnName("email_body");

                entity.Property(e => e.EmailCc)
                    .HasColumnName("email_cc")
                    .HasMaxLength(500);

                entity.Property(e => e.EmailCronExpression)
                    .HasColumnName("email_cron_expression")
                    .HasMaxLength(20);

                entity.Property(e => e.EmailFrom)
                    .IsRequired()
                    .HasColumnName("email_from")
                    .HasMaxLength(100);

                entity.Property(e => e.EmailSchedulerName)
                    .IsRequired()
                    .HasColumnName("email_scheduler_name")
                    .HasMaxLength(500);

                entity.Property(e => e.EmailSchedulerStatusId).HasColumnName("email_scheduler_status_id");

                entity.Property(e => e.EmailSubject)
                    .IsRequired()
                    .HasColumnName("email_subject")
                    .HasMaxLength(1000);

                entity.Property(e => e.EmailTimeZoneId)
                    .HasColumnName("email_time_zone_id")
                    .HasMaxLength(100);

                entity.Property(e => e.EmailTo)
                    .IsRequired()
                    .HasColumnName("email_to")
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<ArsTblEmailSchedulerStatus>(entity =>
            {
                entity.HasKey(e => e.EmailSchedulerStatusId)
                    .HasName("ars_tbl_email_scheduler_status_pkey");

                entity.ToTable("ars_tbl_email_scheduler_status", "master");

                entity.Property(e => e.EmailSchedulerStatusId)
                    .HasColumnName("email_scheduler_status_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmailSchedulerStausName)
                    .IsRequired()
                    .HasColumnName("email_scheduler_staus_name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ArsTblEmailaddress>(entity =>
            {
                entity.HasKey(e => e.EmailId)
                    .HasName("ars_tbl_emailaddress_pkey");

                entity.ToTable("ars_tbl_emailaddress", "master");

                entity.Property(e => e.EmailId)
                    .HasColumnName("email_id")
                    .HasDefaultValueSql("nextval('master.ars_tbl_emailaddress_email_id_seq'::regclass)");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasColumnName("email_address")
                    .HasMaxLength(100);

                entity.Property(e => e.IsDefault).HasColumnName("is_default");
            });

            modelBuilder.Entity<ArsTblFunction>(entity =>
            {
                entity.HasKey(e => e.FunctionId)
                    .HasName("ars_tbl_function_pkey");

                entity.ToTable("ars_tbl_function", "master");

                entity.Property(e => e.FunctionId)
                    .HasColumnName("function_id")
                    .HasDefaultValueSql("nextval('master.ars_tbl_function_function_id_seq'::regclass)");

                entity.Property(e => e.FunctionName)
                    .IsRequired()
                    .HasColumnName("function_name")
                    .HasMaxLength(100);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ReportId).HasColumnName("report_id");

                entity.Property(e => e.SchemaId).HasColumnName("schema_id");
            });

            modelBuilder.Entity<ArsTblLogs>(entity =>
            {
                entity.ToTable("ars_tbl_logs", "master");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('master.ars_tbl_logs_id_seq'::regclass)");

                entity.Property(e => e.Application)
                    .HasColumnName("application")
                    .HasMaxLength(100);

                entity.Property(e => e.Callsite)
                    .HasColumnName("callsite")
                    .HasMaxLength(8000);

                entity.Property(e => e.Exception)
                    .HasColumnName("exception")
                    .HasMaxLength(8000);

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasMaxLength(100);

                entity.Property(e => e.Logged).HasColumnName("logged");

                entity.Property(e => e.Logger)
                    .HasColumnName("logger")
                    .HasMaxLength(8000);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(8000);
            });

            modelBuilder.Entity<ArsTblMenu>(entity =>
            {
                entity.HasKey(e => e.MenuId)
                    .HasName("ars_tbl_menu_pkey");

                entity.ToTable("ars_tbl_menu", "master");

                entity.HasIndex(e => new { e.ParentId, e.IsActive, e.MenuId })
                    .HasName("idx_menu_security")
                    .ForNpgsqlInclude(new[] { "menu_code", "menu_name", "menu_path", "menu_order" });

                entity.Property(e => e.MenuId)
                    .HasColumnName("menu_id")
                    .HasDefaultValueSql("nextval('master.ars_tbl_menu_menu_id_seq'::regclass)");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.MenuCode)
                    .IsRequired()
                    .HasColumnName("menu_code")
                    .HasMaxLength(100);

                entity.Property(e => e.MenuIcon)
                    .HasColumnName("menu_icon")
                    .HasMaxLength(50);

                entity.Property(e => e.MenuName)
                    .IsRequired()
                    .HasColumnName("menu_name")
                    .HasMaxLength(100);

                entity.Property(e => e.MenuOrder).HasColumnName("menu_order");

                entity.Property(e => e.MenuPage)
                    .HasColumnName("menu_page")
                    .HasMaxLength(100);

                entity.Property(e => e.MenuPath)
                    .HasColumnName("menu_path")
                    .HasMaxLength(300);

                entity.Property(e => e.ParentId).HasColumnName("parent_id");
            });

            modelBuilder.Entity<ArsTblParameterSource>(entity =>
            {
                entity.HasKey(e => e.ParameterSourceId)
                    .HasName("ars_tbl_parameter_source_pkey");

                entity.ToTable("ars_tbl_parameter_source", "master");

                entity.Property(e => e.ParameterSourceId)
                    .HasColumnName("parameter_source_id")
                    .HasDefaultValueSql("nextval('master.ars_tbl_parameter_source_parameter_source_id_seq'::regclass)");

                entity.Property(e => e.IsActive)
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ParameterSourceName)
                    .IsRequired()
                    .HasColumnName("parameter_source_name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ArsTblParameterType>(entity =>
            {
                entity.HasKey(e => e.ParameterTypeId)
                    .HasName("ars_tbl_parameter_type_pkey");

                entity.ToTable("ars_tbl_parameter_type", "master");

                entity.Property(e => e.ParameterTypeId)
                    .HasColumnName("parameter_type_id")
                    .HasDefaultValueSql("nextval('master.ars_tbl_parameter_type_parameter_type_id_seq'::regclass)");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ParameterTypeName)
                    .IsRequired()
                    .HasColumnName("parameter_type_name")
                    .HasMaxLength(100);
            });
            
            modelBuilder.Entity<ArsTblReport>(entity =>
            {
                entity.HasKey(e => e.ReportId)
                    .HasName("ars_tbl_report_pkey");

                entity.ToTable("ars_tbl_report", "master");

                entity.Property(e => e.ReportId)
                    .HasColumnName("report_id")
                    .HasDefaultValueSql("nextval('master.ars_tbl_report_report_id_seq'::regclass)");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ReportName)
                    .IsRequired()
                    .HasColumnName("report_name")
                    .HasMaxLength(100);

                entity.Property(e => e.SchemaId).HasColumnName("schema_id");
            });

            modelBuilder.Entity<ArsTblSchema>(entity =>
            {
                entity.HasKey(e => e.SchemaId)
                    .HasName("ars_tbl_schema_pkey");

                entity.ToTable("ars_tbl_schema", "master");

                entity.Property(e => e.SchemaId)
                    .HasColumnName("schema_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CatalogName)
                    .HasColumnName("catalog_name")
                    .HasMaxLength(50);

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

                entity.Property(e => e.SchemaDisplay)
                    .HasColumnName("schema_display")
                    .HasMaxLength(50);

                entity.Property(e => e.SchemaName)
                    .IsRequired()
                    .HasColumnName("schema_name")
                    .HasMaxLength(20);

                entity.Property(e => e.SchemaOrder).HasColumnName("schema_order");

                entity.Property(e => e.SchemaOwner)
                    .HasColumnName("schema_owner")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateBy)
                    .HasColumnName("update_by")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ArsTblReportGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("ars_tbl_report_group_pkey");

                entity.ToTable("ars_tbl_report_group", "master");

                //entity.Property(e => e.GroupId)
                //    .HasColumnName("group_id")
                //    .ValueGeneratedNever();


                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasDefaultValueSql("nextval('master.ars_tbl_report_group_group_id_seq'::regclass)");

                entity.Property(e => e.GroupName)
                    .HasColumnName("group_name")
                    .HasMaxLength(50);

                entity.Property(e => e.SchemaId)
                 .HasColumnName("schema_id")
                 .ValueGeneratedNever();

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate)
                    .IsRequired()
                    .HasColumnName("updated_date")
                    .HasMaxLength(50);

                //entity.Property(e => e.SchemaOrder).HasColumnName("schema_order");

                //entity.Property(e => e.SchemaOwner)
                //    .HasColumnName("schema_owner")
                //    .HasMaxLength(50);
            });

            modelBuilder.Entity<ArsTblReportGroupMapping>(entity =>
            {

                entity.HasKey(e => e.GroupId)
                    .HasName("ars_tbl_report_group_mapping_pkey");

                entity.ToTable("ars_tbl_report_group_mapping", "master");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .ValueGeneratedNever();


                //entity.Property(e => e.GroupId)
                //    .HasColumnName("group_id")
                //    .HasDefaultValueSql("nextval('master.ars_tbl_report_group_group_id_seq'::regclass)");

                //entity.Property(e => e.ReportId)
                //    .HasColumnName("report_id")
                //    .ValueGeneratedNever();

                entity.Property(e => e.ReportName)
                  .IsRequired()
                    .HasColumnName("report_name")
                    .HasMaxLength(200);

                entity.Property(e => e.FunctionName)
                  .IsRequired()
                    .HasColumnName("function_name")
                    .HasMaxLength(200);

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnName("created_date")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate)
                    .IsRequired()
                    .HasColumnName("updated_date")
                    .HasMaxLength(50);

                //entity.Property(e => e.SchemaOrder).HasColumnName("schema_order");

                //entity.Property(e => e.SchemaOwner)
                //    .HasColumnName("schema_owner")
                //    .HasMaxLength(50);
            });

            modelBuilder.Entity<ArsTblTable>(entity =>
            {
                entity.HasKey(e => new { e.Tableid, e.Schemaid })
                    .HasName("ars_tbl_table_pkey");

                entity.ToTable("ars_tbl_table", "master");

                entity.Property(e => e.Tableid).HasColumnName("tableid");

                entity.Property(e => e.Schemaid).HasColumnName("schemaid");

                entity.Property(e => e.Tablename)
                    .IsRequired()
                    .HasColumnName("tablename")
                    .HasColumnType("character(40)");
            });

            modelBuilder.Entity<ArsTblTemplate>(entity =>
            {
                entity.HasKey(e => e.TemplateId)
                    .HasName("ars_tbl_template_pkey");

                entity.ToTable("ars_tbl_template", "master");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasDefaultValueSql("nextval('master.ars_tbl_template_template_id_seq'::regclass)");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TemplateName)
                    .IsRequired()
                    .HasColumnName("template_name")
                    .HasMaxLength(100);

                entity.Property(e => e.TemplatePath)
                    .IsRequired()
                    .HasColumnName("template_path")
                    .HasMaxLength(100);

                entity.Property(e => e.TemplateReportMappingId).HasColumnName("template_report_mapping_id");
            });

            modelBuilder.Entity<ArsTblTemplateColumnMapping>(entity =>
            {
                entity.HasKey(e => e.TemplateColumnMappingId)
                    .HasName("ars_tbl_template_column_mapping_pkey");

                entity.ToTable("ars_tbl_template_column_mapping", "master");

                entity.Property(e => e.TemplateColumnMappingId)
                    .HasColumnName("template_column_mapping_id")
                    .UseNpgsqlIdentityAlwaysColumn();

                entity.Property(e => e.ColumnDataType)
                    .IsRequired()
                    .HasColumnName("column_data_type")
                    .HasMaxLength(200);

                entity.Property(e => e.ColumnDisplay)
                    .HasColumnName("column_display")
                    .HasMaxLength(100);

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasColumnName("column_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ColumnSorting).HasColumnName("column_sorting");

                entity.Property(e => e.DefaultValue)
                    .HasColumnName("default_value")
                    .HasMaxLength(100);

                entity.Property(e => e.Footer)
                    .HasColumnName("footer")
                    .HasMaxLength(100);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TemplateReportMappingId).HasColumnName("template_report_mapping_id");
            });

            modelBuilder.Entity<ArsTblTemplateParameterMapping>(entity =>
            {
                entity.HasKey(e => e.TemplateParameterMappingId)
                    .HasName("ars_tbl_template_parameter_mapping_pkey");

                entity.ToTable("ars_tbl_template_parameter_mapping", "master");

                entity.Property(e => e.TemplateParameterMappingId)
                    .HasColumnName("template_parameter_mapping_id")
                    .HasDefaultValueSql("nextval('master.ars_tbl_template_parameter_ma_template_parameter_mapping_id_seq'::regclass)");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.OrdinalPosition).HasColumnName("ordinal_position");

                entity.Property(e => e.ParameterDataTypeId).HasColumnName("parameter_data_type_id");

                entity.Property(e => e.ParameterDefaultValue).HasColumnName("parameter_default_value");

                entity.Property(e => e.ParameterName)
                    .IsRequired()
                    .HasColumnName("parameter_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParameterSourceColumn)
                    .HasColumnName("parameter_source_column")
                    .HasMaxLength(100);

                entity.Property(e => e.ParameterSourceId).HasColumnName("parameter_source_id");

                entity.Property(e => e.ParameterSourceQuery).HasColumnName("parameter_source_query");

                entity.Property(e => e.ParameterTypeId).HasColumnName("parameter_type_id");

                entity.Property(e => e.ParameterUdtName)
                    .HasColumnName("parameter_udt_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.TemplateReportMappingId).HasColumnName("template_report_mapping_id");
            });

            modelBuilder.Entity<ArsTblTemplateReportMapping>(entity =>
            {
                entity.HasKey(e => e.TemplateReportMappingId)
                    .HasName("ars_tbl_template_report_mapping_pkey");

                entity.ToTable("ars_tbl_template_report_mapping", "master");

                entity.Property(e => e.TemplateReportMappingId)
                    .HasColumnName("template_report_mapping_id")
                    .HasDefaultValueSql("nextval('master.ars_tbl_template_report_mapping_template_report_mapping_id_seq'::regclass)");

                entity.Property(e => e.FunctionId).HasColumnName("function_id");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ReportDesc)
                    .IsRequired()
                    .HasColumnName("report_desc")
                    .HasMaxLength(200);

                entity.Property(e => e.ReportId).HasColumnName("report_id");
                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.SchemaId).HasColumnName("schema_id");

                entity.Property(e => e.FunctionName)
                    .HasColumnName("function_name")
                    .HasMaxLength(200);

                entity.Property(e => e.TemplateName)
                    .HasColumnName("template_name")
                    .HasMaxLength(200);

                entity.Property(e => e.TemplatePath)
                    .HasColumnName("template_path")
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<ArsTblTemplateTrigger>(entity =>
            {
                entity.HasKey(e => e.TemplateTriggerId)
                    .HasName("ars_tbl_template_trigger_pkey");

                entity.ToTable("ars_tbl_template_trigger", "master");

                entity.Property(e => e.TemplateTriggerId)
                    .HasColumnName("template_trigger_id")
                    .UseNpgsqlIdentityAlwaysColumn();

                entity.Property(e => e.DailyTime)
                    .HasColumnName("daily_time")
                    .HasMaxLength(6);

                entity.Property(e => e.DailyType)
                    .HasColumnName("daily_type")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.EndOfMonth).HasColumnName("end_of_month");

                entity.Property(e => e.Hours).HasColumnName("hours");

                entity.Property(e => e.Minutes).HasColumnName("minutes");

                entity.Property(e => e.MonthlyTime)
                    .HasColumnName("monthly_time")
                    .HasMaxLength(6);

                entity.Property(e => e.SelectedDates).HasColumnName("selected_dates");

                entity.Property(e => e.TabNumber)
                    .HasColumnName("tab_number")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TemplateBcc)
                    .HasColumnName("template_bcc")
                    .HasMaxLength(500);

                entity.Property(e => e.TemplateBody).HasColumnName("template_body");

                entity.Property(e => e.TemplateCc)
                    .HasColumnName("template_cc")
                    .HasMaxLength(500);

                entity.Property(e => e.TemplateFrom)
                    .IsRequired()
                    .HasColumnName("template_from")
                    .HasMaxLength(100);

                entity.Property(e => e.TemplateSchedName)
                    .IsRequired()
                    .HasColumnName("template_sched_name")
                    .HasMaxLength(500);

                entity.Property(e => e.TemplateSubject)
                    .IsRequired()
                    .HasColumnName("template_subject")
                    .HasMaxLength(1000);

                entity.Property(e => e.TemplateTo)
                    .IsRequired()
                    .HasColumnName("template_to")
                    .HasMaxLength(1000);

                entity.Property(e => e.TemplateTriggerGroup)
                    .IsRequired()
                    .HasColumnName("template_trigger_group")
                    .HasMaxLength(500);

                entity.Property(e => e.TemplateTriggerName)
                    .IsRequired()
                    .HasColumnName("template_trigger_name")
                    .HasMaxLength(500);

                entity.Property(e => e.Weekly)
                    .HasColumnName("weekly")
                    .HasColumnType("character varying[]");

                entity.Property(e => e.WeeklyTime)
                    .HasColumnName("weekly_time")
                    .HasMaxLength(6);
            });

            modelBuilder.HasSequence<int>("ars_tbl_data_type_data_type_id_seq");

            modelBuilder.HasSequence<int>("ars_tbl_emailaddress_email_id_seq");

            modelBuilder.HasSequence<int>("ars_tbl_function_function_id_seq");

            modelBuilder.HasSequence<int>("ars_tbl_logs_id_seq");

            modelBuilder.HasSequence<int>("ars_tbl_menu_menu_id_seq");

            modelBuilder.HasSequence<int>("ars_tbl_parameter_source_parameter_source_id_seq");

            modelBuilder.HasSequence<int>("ars_tbl_parameter_type_parameter_type_id_seq");

            modelBuilder.HasSequence<int>("ars_tbl_report_report_id_seq");

            modelBuilder.HasSequence<int>("ars_tbl_template_parameter_ma_template_parameter_mapping_id_seq");

            modelBuilder.HasSequence<int>("ars_tbl_template_report_mapping_template_report_mapping_id_seq");

            modelBuilder.HasSequence<int>("ars_tbl_template_template_id_seq");

            modelBuilder.HasSequence<int>("ars_tbs_RoleClaim_Id_seq");

            modelBuilder.HasSequence<int>("ars_tbs_UserClaim_Id_seq");
        }
    }
}
