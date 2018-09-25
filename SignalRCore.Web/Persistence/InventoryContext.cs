using SignalRCore.Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace SignalRCore.Web.Persistence
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options)
            : base(options)
        {
        }
        public InventoryContext()
        {

        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        
        public virtual DbSet<AgentLogins> AgentLogins { get; set; }
        public virtual DbSet<Agents> Agents { get; set; }
        public virtual DbSet<ClientProfile> ClientProfile { get; set; }
        public virtual DbSet<ClientSetup> ClientSetup { get; set; }
        public virtual DbSet<Constituencies> Constituencies { get; set; }
        public virtual DbSet<Counties> Counties { get; set; }
        public virtual DbSet<CountyOfficers> CountyOfficers { get; set; }
        public virtual DbSet<Dependants> Dependants { get; set; }
        public virtual DbSet<DepositRequests> DepositRequests { get; set; }
        public virtual DbSet<Deposits> Deposits { get; set; }
        public virtual DbSet<Facility> Facility { get; set; }
        public virtual DbSet<FacilityKephlevel> FacilityKephlevel { get; set; }
        public virtual DbSet<ImageData> ImageData { get; set; }
        public virtual DbSet<KituiSubcounties> KituiSubcounties { get; set; }
        public virtual DbSet<MemberLedgerEntries> MemberLedgerEntries { get; set; }

        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<Principals> Principals { get; set; }
        public virtual DbSet<RemmittanceMatrices> RemmittanceMatrices { get; set; }
        public virtual DbSet<RemmittancePlans> RemmittancePlans { get; set; }
        public virtual DbSet<Spouses> Spouses { get; set; }
        public virtual DbSet<TheCounties> TheCounties { get; set; }
        public virtual DbSet<TheSubCounties> TheSubCounties { get; set; }
        public virtual DbSet<TheWards> TheWards { get; set; }
        public virtual DbSet<TransactionTypes> TransactionTypes { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Wards> Wards { get; set; }
        public virtual DbSet<AppUsers> AppUsers { get; set; }

        public virtual DbSet<BulkPayment> BulkPayments { get; set; }

        // Unable to generate entity type for table 'dbo.RegistrationFields'. Please see the warning messages.



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AgentLogins>(entity =>
            {
                entity.Property(e => e.LoginDate).HasColumnType("datetime");

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<Agents>(entity =>
            {
                entity.Property(e => e.IdNumber).HasMaxLength(450);

                entity.Property(e => e.Subcounty).HasColumnName("SUBCOUNTY");

                entity.Property(e => e.TerminalId).HasMaxLength(450);

                entity.Property(e => e.Village).HasColumnName("VILLAGE");

                entity.Property(e => e.Ward).HasColumnName("WARD");
            });

            modelBuilder.Entity<ClientProfile>(entity =>
            {
                entity.Property(e => e.Business).HasMaxLength(50);

                entity.Property(e => e.ClientCode)
                    .IsRequired()
                    .HasMaxLength(7);

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Comments).HasMaxLength(200);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.Currency).HasMaxLength(10);

                entity.Property(e => e.DateModified).HasColumnType("date");

                entity.Property(e => e.Datecreated).HasColumnType("date");

                entity.Property(e => e.DefaultCode).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Language).HasMaxLength(50);

                entity.Property(e => e.Mediaurl).HasMaxLength(80);
            });

            modelBuilder.Entity<ClientSetup>(entity =>
            {
                entity.Property(e => e.ClientCode)
                    .IsRequired()
                    .HasMaxLength(7);

                entity.Property(e => e.NotifyViaSms).HasColumnName("NotifyViaSMS");
            });

            modelBuilder.Entity<Constituencies>(entity =>
            {
                entity.ToTable("constituencies");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ConstCode).HasColumnName("CONST_CODE");

                entity.Property(e => e.Constituen)
                    .HasColumnName("CONSTITUEN")
                    .HasMaxLength(255);

                entity.Property(e => e.CountyA1)
                    .HasColumnName("COUNTY_A_1")
                    .HasMaxLength(255);

                entity.Property(e => e.CountyAss).HasColumnName("COUNTY_ASS");

                entity.Property(e => e.CountyCod).HasColumnName("COUNTY_COD");

                entity.Property(e => e.CountyNam)
                    .HasColumnName("COUNTY_NAM")
                    .HasMaxLength(255);

                entity.Property(e => e.Objectid).HasColumnName("OBJECTID");

                entity.Property(e => e.RegistCen).HasColumnName("REGIST_CEN");

                entity.Property(e => e.Registrati)
                    .HasColumnName("REGISTRATI")
                    .HasMaxLength(255);

                entity.Property(e => e.ShapeArea).HasColumnName("Shape_Area");

                entity.Property(e => e.ShapeLeng).HasColumnName("Shape_Leng");
            });

            modelBuilder.Entity<Counties>(entity =>
            {
                entity.ToTable("counties");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ConstCode).HasColumnName("CONST_CODE");

                entity.Property(e => e.Constituen)
                    .HasColumnName("CONSTITUEN")
                    .HasMaxLength(255);

                entity.Property(e => e.CountyCod).HasColumnName("COUNTY_COD");

                entity.Property(e => e.CountyNam)
                    .HasColumnName("COUNTY_NAM")
                    .HasMaxLength(255);

                entity.Property(e => e.Id1).HasColumnName("ID_");

                entity.Property(e => e.Objectid).HasColumnName("OBJECTID");

                entity.Property(e => e.ShapeArea).HasColumnName("Shape_Area");

                entity.Property(e => e.ShapeLeng).HasColumnName("Shape_Leng");
            });

            modelBuilder.Entity<CountyOfficers>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.HasOne(d => d.County)
                    .WithMany(p => p.CountyOfficers)
                    .HasForeignKey(d => d.CountyId)
                    .HasConstraintName("FK_dbo.CountyOfficers_dbo.TheCounties_CountyId");
            });

            modelBuilder.Entity<Dependants>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Dependants)
                    .HasForeignKey<Dependants>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Dependants_dbo.People_Id");

                entity.HasOne(d => d.Principal)
                    .WithMany(p => p.Dependants)
                    .HasForeignKey(d => d.PrincipalId)
                    .HasConstraintName("FK_dbo.Dependants_dbo.Principals_PrincipalId");
            });

            modelBuilder.Entity<Deposits>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DocumentNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Facility>(entity =>
            {
                entity.Property(e => e.FacilityAddress).HasMaxLength(50);

                entity.Property(e => e.FacilityLatitude).HasMaxLength(50);

                entity.Property(e => e.FacilityLongitude).HasMaxLength(50);

                entity.Property(e => e.FacilityName).HasMaxLength(50);

                entity.Property(e => e.FacilityOwner).HasMaxLength(50);

                entity.Property(e => e.Kephlevel).HasColumnName("KEPHLevel");
            });

            modelBuilder.Entity<FacilityKephlevel>(entity =>
            {
                entity.ToTable("FacilityKEPHLevel");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Kephlevel)
                    .IsRequired()
                    .HasColumnName("KEPHLevel")
                    .HasMaxLength(50);

                entity.Property(e => e.KephlevelName)
                    .IsRequired()
                    .HasColumnName("KEPHLevelName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ImageData>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.InverseIdNavigation)
                    .HasForeignKey<ImageData>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImageData_ImageData1");
            });

            modelBuilder.Entity<KituiSubcounties>(entity =>
            {
                entity.ToTable("kituiSubcounties");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cca2)
                    .HasColumnName("CCA_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Ccn2).HasColumnName("CCN_2");

                entity.Property(e => e.Engtype2)
                    .HasColumnName("ENGTYPE_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Hasc2)
                    .HasColumnName("HASC_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Id0).HasColumnName("ID_0");

                entity.Property(e => e.Id1).HasColumnName("ID_1");

                entity.Property(e => e.Id2).HasColumnName("ID_2");

                entity.Property(e => e.Iso)
                    .HasColumnName("ISO")
                    .HasMaxLength(255);

                entity.Property(e => e.Name0)
                    .HasColumnName("NAME_0")
                    .HasMaxLength(255);

                entity.Property(e => e.Name1)
                    .HasColumnName("NAME_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Name2)
                    .HasColumnName("NAME_2")
                    .HasMaxLength(255);

                entity.Property(e => e.NlName2)
                    .HasColumnName("NL_NAME_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Type2)
                    .HasColumnName("TYPE_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Varname2)
                    .HasColumnName("VARNAME_2")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<MemberLedgerEntries>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.PaymentEndDate).HasColumnType("datetime");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");
            });


            modelBuilder.Entity<Payments>(entity =>
            {
                entity.Property(e => e.AccountNo).HasMaxLength(50);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CardNo).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.DocumentNo).HasMaxLength(50);

                entity.Property(e => e.MemberNo).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(100);

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentMode).HasMaxLength(50);

                entity.Property(e => e.PaymentType).HasMaxLength(50);

                entity.Property(e => e.PhoneNo).HasMaxLength(50);

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<People>(entity =>
            {
                entity.Property(e => e.CardPrintDate).HasColumnType("datetime");

                entity.Property(e => e.CardUid)
                    .HasColumnName("CardUID")
                    .HasMaxLength(150);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.IdentificationNo).HasMaxLength(50);

                entity.Property(e => e.IdentificationType).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MaritalStatus).HasMaxLength(50);

                entity.Property(e => e.MemberNo).HasMaxLength(30);

                entity.Property(e => e.MemberType).HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.Occupation).HasMaxLength(60);

                entity.Property(e => e.OldMemberNo).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.PhysicalAddress).HasMaxLength(150);

                entity.Property(e => e.PinNo).HasMaxLength(50);

                entity.Property(e => e.TerminalId).HasMaxLength(50);
            });

            modelBuilder.Entity<Principals>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Principals)
                    .HasForeignKey<Principals>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Principals_dbo.People_Id");
            });

            modelBuilder.Entity<RemmittanceMatrices>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.RemmittanceMatrices)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("FK_dbo.RemmittanceMatrices_dbo.RemmittancePlans_PlanId");
            });

            modelBuilder.Entity<RemmittancePlans>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");
            });

            modelBuilder.Entity<Spouses>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Spouses)
                    .HasForeignKey<Spouses>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Spouses_dbo.People_Id");

                entity.HasOne(d => d.Principal)
                    .WithMany(p => p.Spouses)
                    .HasForeignKey(d => d.PrincipalId)
                    .HasConstraintName("FK_dbo.Spouses_dbo.Principals_PrincipalId");
            });

            modelBuilder.Entity<TheCounties>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");
            });

            modelBuilder.Entity<TheSubCounties>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.HasOne(d => d.County)
                    .WithMany(p => p.TheSubCounties)
                    .HasForeignKey(d => d.CountyId)
                    .HasConstraintName("FK_dbo.TheSubCounties_dbo.TheCounties_CountyId");
            });

            modelBuilder.Entity<TheWards>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.HasOne(d => d.SubCounty)
                    .WithMany(p => p.TheWards)
                    .HasForeignKey(d => d.SubCountyId)
                    .HasConstraintName("FK_dbo.TheWards_dbo.TheSubCounties_SubCountyId");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.IdNumber).HasMaxLength(450);

                entity.Property(e => e.Subcounty).HasColumnName("SUBCOUNTY");

                entity.Property(e => e.TerminalId).HasMaxLength(450);

                entity.Property(e => e.Village).HasColumnName("VILLAGE");

                entity.Property(e => e.Ward).HasColumnName("WARD");
            });

            modelBuilder.Entity<Wards>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ConstCode).HasColumnName("CONST_CODE");

                entity.Property(e => e.Constituen)
                    .HasColumnName("CONSTITUEN")
                    .HasMaxLength(255);

                entity.Property(e => e.CountyA1)
                    .HasColumnName("COUNTY_A_1")
                    .HasMaxLength(255);

                entity.Property(e => e.CountyAss).HasColumnName("COUNTY_ASS");

                entity.Property(e => e.CountyCod).HasColumnName("COUNTY_COD");

                entity.Property(e => e.CountyNam)
                    .HasColumnName("COUNTY_NAM")
                    .HasMaxLength(255);

                entity.Property(e => e.Disputed).HasColumnName("DISPUTED");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Objectid).HasColumnName("OBJECTID");

                entity.Property(e => e.Objectid1).HasColumnName("OBJECTID_1");

                entity.Property(e => e.Registered)
                    .HasColumnName("REGISTERED")
                    .HasMaxLength(255);

                entity.Property(e => e.Rejected).HasColumnName("REJECTED");

                entity.Property(e => e.Reported).HasColumnName("REPORTED");

                entity.Property(e => e.Result)
                    .HasColumnName("RESULT")
                    .HasMaxLength(255);

                entity.Property(e => e.ShapeArea).HasColumnName("Shape_Area");

                entity.Property(e => e.ShapeLe1).HasColumnName("Shape_Le_1");

                entity.Property(e => e.ShapeLeng).HasColumnName("Shape_Leng");

                entity.Property(e => e.Spoilt).HasColumnName("SPOILT");

                entity.Property(e => e.SpoiltVal).HasColumnName("SPOILT_VAL");

                entity.Property(e => e.Valid).HasColumnName("VALID");
            });
        }

    }
}
