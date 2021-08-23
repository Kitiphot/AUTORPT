using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SCG.ARS.BOI.WEB.Entities.QaDataLakePKGDb
{
    public partial class QaPKGContext : DbContext
    {
        public QaPKGContext()
        {
        }

        public QaPKGContext(DbContextOptions<QaPKGContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DbBooking> DbBooking { get; set; }
        public virtual DbSet<DbOrderAccept> DbOrderAccept { get; set; }
        public virtual DbSet<DbOrderNonAccept> DbOrderNonAccept { get; set; }
        public virtual DbSet<MasterBackhaul> MasterBackhaul { get; set; }
        public virtual DbSet<MasterCarrierName> MasterCarrierName { get; set; }
        public virtual DbSet<MasterGroupingDistanceShipto> MasterGroupingDistanceShipto { get; set; }
        public virtual DbSet<MasterTruck> MasterTruck { get; set; }
        public virtual DbSet<TmpBooking> TmpBooking { get; set; }
        public virtual DbSet<TmpOrderAccept> TmpOrderAccept { get; set; }
        public virtual DbSet<TmpOrderNonAccept> TmpOrderNonAccept { get; set; }

        // Unable to generate entity type for table 'pkg.master_commit'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=qa-datalake-pg.cluster-ctg0nvlybzpq.ap-southeast-1.rds.amazonaws.com; Username =csi_report; Password =CSI@SCGL; Database =pd_datalake", x => x.UseNodaTime());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("pg_trgm")
                .HasPostgresExtension("postgis")
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<DbBooking>(entity =>
            {
                entity.HasKey(e => e.TruckLicense)
                    .HasName("booking_pkey");

                entity.ToTable("db_booking", "pkg");

                entity.Property(e => e.TruckLicense)
                    .HasColumnName("Truck_License")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Carrier).HasMaxLength(10);

                entity.Property(e => e.DriverName)
                    .HasColumnName("Driver_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.Fleet).HasMaxLength(10);

                entity.Property(e => e.ShippingPoint).HasMaxLength(50);

                entity.Property(e => e.SubTruckType)
                    .IsRequired()
                    .HasColumnName("Sub_Truck_Type")
                    .HasMaxLength(20);

                entity.Property(e => e.TimeStampBooking)
                    .HasColumnName("TimeStamp_Booking")
                    .HasColumnType("timestamp(4) without time zone");

                entity.Property(e => e.TruckType)
                    .IsRequired()
                    .HasColumnName("Truck_Type")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<DbOrderAccept>(entity =>
            {
                entity.HasKey(e => e.DPNo)
                    .HasName("order_accept_pkey");

                entity.ToTable("db_order_accept", "pkg");

                entity.Property(e => e.DPNo)
                    .HasColumnName("D/P_No")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Carrier).HasMaxLength(100);

                entity.Property(e => e.Fleet).HasMaxLength(20);

                entity.Property(e => e.Shipment).HasMaxLength(20);

                entity.Property(e => e.Shipment2).HasMaxLength(20);

                entity.Property(e => e.SubTruckType)
                    .HasColumnName("Sub_Truck_Type")
                    .HasMaxLength(50);

                entity.Property(e => e.TruckLicense)
                    .HasColumnName("Truck_License")
                    .HasMaxLength(20);

                entity.Property(e => e.กำหนดสง)
                    .HasColumnName("กำหนดส่ง")
                    .HasMaxLength(20);

                entity.Property(e => e.ขนสนคาเสรจสถานะ4)
                    .HasColumnName("ขึ้นสินค้าเสร็จ(สถานะ4)")
                    .HasMaxLength(20);

                entity.Property(e => e.คนใบDpสถานะ9)
                    .HasColumnName("คืนใบ DP(สถานะ9)")
                    .HasMaxLength(20);

                entity.Property(e => e.จองควสถานะ1)
                    .HasColumnName("จองคิว(สถานะ1)")
                    .HasMaxLength(20);

                entity.Property(e => e.จายงานสถานะ1)
                    .HasColumnName("จ่ายงาน(สถานะ1*)")
                    .HasMaxLength(20);

                entity.Property(e => e.ตอบรบงานสถานะ2)
                    .HasColumnName("ตอบรับงาน(สถานะ2)")
                    .HasMaxLength(20);

                entity.Property(e => e.ถงจดรบbhสถานะ7)
                    .HasColumnName("ถึงจุดรับBH(สถานะ7)")
                    .HasMaxLength(20);

                entity.Property(e => e.ประเภทรถ).HasMaxLength(50);

                entity.Property(e => e.ผขนสง)
                    .HasColumnName("ผู้ขนส่ง")
                    .HasMaxLength(20);

                entity.Property(e => e.รอขนสนคาสถานะ3)
                    .HasColumnName("รอขึ้นสินค้า(สถานะ3)")
                    .HasMaxLength(20);

                entity.Property(e => e.รอลงสนคาสถานะ5)
                    .HasColumnName("รอลงสินค้า(สถานะ5)")
                    .HasMaxLength(20);

                entity.Property(e => e.รอลงเศษสถานะ8)
                    .HasColumnName("รอลงเศษ(สถานะ8)")
                    .HasMaxLength(20);

                entity.Property(e => e.ลกคา)
                    .HasColumnName("ลูกค้า")
                    .HasMaxLength(100);

                entity.Property(e => e.สถานทขนสนคา)
                    .HasColumnName("สถานที่ขึ้นสินค้า")
                    .HasMaxLength(100);

                entity.Property(e => e.สถานทสง)
                    .HasColumnName("สถานที่ส่ง")
                    .HasMaxLength(100);

                entity.Property(e => e.ออกจากbhสถานะ71)
                    .HasColumnName("ออกจากBH(สถานะ7.1)")
                    .HasMaxLength(20);

                entity.Property(e => e.ออกจากโรงงานสถานะ41)
                    .HasColumnName("ออกจากโรงงาน(สถานะ4.1)")
                    .HasMaxLength(20);

                entity.Property(e => e.เขาโรงงานสถานะ21)
                    .HasColumnName("เข้าโรงงาน(สถานะ2.1)")
                    .HasMaxLength(20);

                entity.Property(e => e.เดนทางกลบสถานะ6)
                    .HasColumnName("เดินทางกลับ(สถานะ6)")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<DbOrderNonAccept>(entity =>
            {
                entity.HasKey(e => e.Shipment)
                    .HasName("order_non_accept_pkey");

                entity.ToTable("db_order_non_accept", "pkg");

                entity.Property(e => e.Shipment)
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.DueDate)
                    .HasColumnName("Due_date")
                    .HasMaxLength(50);

                entity.Property(e => e.Fleet).HasMaxLength(20);

                entity.Property(e => e.ShipTo)
                    .HasColumnName("Ship_to")
                    .HasMaxLength(100);

                entity.Property(e => e.SoldTo)
                    .HasColumnName("Sold_to")
                    .HasMaxLength(100);

                entity.Property(e => e.TruckType)
                    .HasColumnName("Truck_Type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MasterBackhaul>(entity =>
            {
                entity.HasKey(e => e.สถานทสง)
                    .HasName("master_backhaul_pkey");

                entity.ToTable("master_backhaul", "pkg");

                entity.Property(e => e.สถานทสง)
                    .HasColumnName("สถานที่ส่ง")
                    .HasMaxLength(100)
                    .ValueGeneratedNever();

                entity.Property(e => e.Model).HasMaxLength(100);

                entity.Property(e => e.จำนวนหางทง).HasColumnName("จำนวนหางทิ้ง");
            });

            modelBuilder.Entity<MasterCarrierName>(entity =>
            {
                entity.HasKey(e => e.CarrierCode)
                    .HasName("master_carrier_name_pkey");

                entity.ToTable("master_carrier_name", "pkg");

                entity.Property(e => e.CarrierCode)
                    .HasColumnName("carrier_code")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.CarrierName)
                    .HasColumnName("carrier_name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MasterGroupingDistanceShipto>(entity =>
            {
                entity.HasKey(e => e.ShipToName)
                    .HasName("master_grouping_distance_shipto_pkey");

                entity.ToTable("master_grouping_distance_shipto", "pkg");

                entity.Property(e => e.ShipToName)
                    .HasColumnName("ship_to_name")
                    .HasMaxLength(100)
                    .ValueGeneratedNever();

                entity.Property(e => e.Group)
                    .HasColumnName("group")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<MasterTruck>(entity =>
            {
                entity.HasKey(e => e.TruckLicence)
                    .HasName("master_truck_pkey");

                entity.ToTable("master_truck", "pkg");

                entity.Property(e => e.TruckLicence)
                    .HasColumnName("Truck_Licence")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Carrier).HasMaxLength(10);

                entity.Property(e => e.CarrierName)
                    .HasColumnName("Carrier_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.DriverName)
                    .HasColumnName("Driver_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Fleet).HasMaxLength(10);

                entity.Property(e => e.SubTrucktypeName)
                    .HasColumnName("SUB_TRUCKTYPE_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.TruckType)
                    .HasColumnName("Truck_Type")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<TmpBooking>(entity =>
            {
                entity.HasKey(e => e.TruckLicense)
                    .HasName("tmp_booking_pkey");

                entity.ToTable("tmp_booking", "pkg");

                entity.Property(e => e.TruckLicense)
                    .HasColumnName("Truck_License")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Carrier).HasMaxLength(10);

                entity.Property(e => e.DriverName)
                    .HasColumnName("Driver_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.Fleet).HasMaxLength(10);

                entity.Property(e => e.ShippingPoint).HasMaxLength(50);

                entity.Property(e => e.SubTruckType)
                    .IsRequired()
                    .HasColumnName("Sub_Truck_Type")
                    .HasMaxLength(20);

                entity.Property(e => e.TimeStampBooking)
                    .HasColumnName("TimeStamp_Booking")
                    .HasColumnType("timestamp(4) without time zone");

                entity.Property(e => e.TruckType)
                    .IsRequired()
                    .HasColumnName("Truck_Type")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TmpOrderAccept>(entity =>
            {
                entity.HasKey(e => e.DPNo)
                    .HasName("tmp_order_accept_pkey");

                entity.ToTable("tmp_order_accept", "pkg");

                entity.Property(e => e.DPNo)
                    .HasColumnName("D/P_No")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Carrier).HasMaxLength(100);

                entity.Property(e => e.Fleet).HasMaxLength(20);

                entity.Property(e => e.Shipment).HasMaxLength(20);

                entity.Property(e => e.Shipment2)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SubTruckType)
                    .HasColumnName("Sub_Truck_Type")
                    .HasMaxLength(50);

                entity.Property(e => e.TruckLicense)
                    .HasColumnName("Truck_License")
                    .HasMaxLength(20);

                entity.Property(e => e.กำหนดสง)
                    .HasColumnName("กำหนดส่ง")
                    .HasMaxLength(20);

                entity.Property(e => e.ขนสนคาเสรจสถานะ4)
                    .HasColumnName("ขึ้นสินค้าเสร็จ(สถานะ4)")
                    .HasMaxLength(20);

                entity.Property(e => e.คนใบDpสถานะ9)
                    .HasColumnName("คืนใบ DP(สถานะ9)")
                    .HasMaxLength(20);

                entity.Property(e => e.จองควสถานะ1)
                    .HasColumnName("จองคิว(สถานะ1)")
                    .HasMaxLength(20);

                entity.Property(e => e.จายงานสถานะ1)
                    .HasColumnName("จ่ายงาน(สถานะ1*)")
                    .HasMaxLength(20);

                entity.Property(e => e.ตอบรบงานสถานะ2)
                    .HasColumnName("ตอบรับงาน(สถานะ2)")
                    .HasMaxLength(20);

                entity.Property(e => e.ถงจดรบbhสถานะ7)
                    .HasColumnName("ถึงจุดรับBH(สถานะ7)")
                    .HasMaxLength(20);

                entity.Property(e => e.ประเภทรถ).HasMaxLength(50);

                entity.Property(e => e.ผขนสง)
                    .HasColumnName("ผู้ขนส่ง")
                    .HasMaxLength(20);

                entity.Property(e => e.รอขนสนคาสถานะ3)
                    .HasColumnName("รอขึ้นสินค้า(สถานะ3)")
                    .HasMaxLength(20);

                entity.Property(e => e.รอลงสนคาสถานะ5)
                    .HasColumnName("รอลงสินค้า(สถานะ5)")
                    .HasMaxLength(20);

                entity.Property(e => e.รอลงเศษสถานะ8)
                    .HasColumnName("รอลงเศษ(สถานะ8)")
                    .HasMaxLength(20);

                entity.Property(e => e.ลกคา)
                    .HasColumnName("ลูกค้า")
                    .HasMaxLength(100);

                entity.Property(e => e.สถานทขนสนคา)
                    .HasColumnName("สถานที่ขึ้นสินค้า")
                    .HasMaxLength(100);

                entity.Property(e => e.สถานทสง)
                    .HasColumnName("สถานที่ส่ง")
                    .HasMaxLength(100);

                entity.Property(e => e.ออกจากbhสถานะ71)
                    .HasColumnName("ออกจากBH(สถานะ7.1)")
                    .HasMaxLength(20);

                entity.Property(e => e.ออกจากโรงงานสถานะ41)
                    .HasColumnName("ออกจากโรงงาน(สถานะ4.1)")
                    .HasMaxLength(20);

                entity.Property(e => e.เขาโรงงานสถานะ21)
                    .HasColumnName("เข้าโรงงาน(สถานะ2.1)")
                    .HasMaxLength(20);

                entity.Property(e => e.เดนทางกลบสถานะ6)
                    .HasColumnName("เดินทางกลับ(สถานะ6)")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TmpOrderNonAccept>(entity =>
            {
                entity.HasKey(e => e.Shipment)
                    .HasName("tmp_order_non_accept_pkey");

                entity.ToTable("tmp_order_non_accept", "pkg");

                entity.Property(e => e.Shipment)
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.DueDate)
                    .HasColumnName("Due_date")
                    .HasMaxLength(50);

                entity.Property(e => e.Fleet).HasMaxLength(20);

                entity.Property(e => e.ShipTo)
                    .HasColumnName("Ship_to")
                    .HasMaxLength(100);

                entity.Property(e => e.SoldTo)
                    .HasColumnName("Sold_to")
                    .HasMaxLength(100);

                entity.Property(e => e.TruckType)
                    .HasColumnName("Truck_Type")
                    .HasMaxLength(50);
            });
        }
    }
}
