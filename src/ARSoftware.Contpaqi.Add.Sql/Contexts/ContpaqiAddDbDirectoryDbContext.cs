using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory;

namespace ARSoftware.Contpaqi.Add.Sql.Contexts
{
    public partial class ContpaqiAddDbDirectoryDbContext : DbContext
    {
        public ContpaqiAddDbDirectoryDbContext()
        {
        }

        public ContpaqiAddDbDirectoryDbContext(DbContextOptions<ContpaqiAddDbDirectoryDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cat_MetaType> Cat_MetaType { get; set; } = null!;
        public virtual DbSet<Cat_Process> Cat_Process { get; set; } = null!;
        public virtual DbSet<Certificates> Certificates { get; set; } = null!;
        public virtual DbSet<DatabaseDirectory> DatabaseDirectory { get; set; } = null!;
        public virtual DbSet<DocumentosDuplicados> DocumentosDuplicados { get; set; } = null!;
        public virtual DbSet<EFOS> EFOS { get; set; } = null!;
        public virtual DbSet<EFOS_Version> EFOS_Version { get; set; } = null!;
        public virtual DbSet<MergeDocs> MergeDocs { get; set; } = null!;
        public virtual DbSet<MergeProcess> MergeProcess { get; set; } = null!;
        public virtual DbSet<Owners> Owners { get; set; } = null!;
        public virtual DbSet<ProcessControl> ProcessControl { get; set; } = null!;
        public virtual DbSet<Schema_CompaniesProgObj> Schema_CompaniesProgObj { get; set; } = null!;
        public virtual DbSet<Schema_CompaniesProgObj_Temp> Schema_CompaniesProgObj_Temp { get; set; } = null!;
        public virtual DbSet<Schema_T_Control> Schema_T_Control { get; set; } = null!;
        public virtual DbSet<Schema_T_CurrentObjectIns> Schema_T_CurrentObjectIns { get; set; } = null!;
        public virtual DbSet<Schema_T_DB_Inventory_Constraints> Schema_T_DB_Inventory_Constraints { get; set; } = null!;
        public virtual DbSet<Schema_T_DB_Inventory_Constraints_Temp> Schema_T_DB_Inventory_Constraints_Temp { get; set; } = null!;
        public virtual DbSet<Schema_T_DB_Inventory_Functions> Schema_T_DB_Inventory_Functions { get; set; } = null!;
        public virtual DbSet<Schema_T_DB_Inventory_Functions_Temp> Schema_T_DB_Inventory_Functions_Temp { get; set; } = null!;
        public virtual DbSet<Schema_T_DB_Inventory_SP> Schema_T_DB_Inventory_SP { get; set; } = null!;
        public virtual DbSet<Schema_T_DB_Inventory_SP_Temp> Schema_T_DB_Inventory_SP_Temp { get; set; } = null!;
        public virtual DbSet<Schema_T_DB_Inventory_Table_Detail> Schema_T_DB_Inventory_Table_Detail { get; set; } = null!;
        public virtual DbSet<Schema_T_DB_Inventory_Table_Detail_Temp> Schema_T_DB_Inventory_Table_Detail_Temp { get; set; } = null!;
        public virtual DbSet<Schema_T_DB_Inventory_Tables> Schema_T_DB_Inventory_Tables { get; set; } = null!;
        public virtual DbSet<Schema_T_DB_Inventory_Tables_Temp> Schema_T_DB_Inventory_Tables_Temp { get; set; } = null!;
        public virtual DbSet<Schema_T_DB_Inventory_Views> Schema_T_DB_Inventory_Views { get; set; } = null!;
        public virtual DbSet<Schema_T_DB_Inventory_Views_Temp> Schema_T_DB_Inventory_Views_Temp { get; set; } = null!;
        public virtual DbSet<Schema_T_DB_Objects> Schema_T_DB_Objects { get; set; } = null!;
        public virtual DbSet<Schema_T_DB_Templates> Schema_T_DB_Templates { get; set; } = null!;
        public virtual DbSet<Schema_T_DB_TypeSpec> Schema_T_DB_TypeSpec { get; set; } = null!;
        public virtual DbSet<Schema_T_DB_Types> Schema_T_DB_Types { get; set; } = null!;
        public virtual DbSet<Schema_T_DB_Versions> Schema_T_DB_Versions { get; set; } = null!;
        public virtual DbSet<Schema_T_Log> Schema_T_Log { get; set; } = null!;
        public virtual DbSet<TempCountDocs> TempCountDocs { get; set; } = null!;
        public virtual DbSet<TempDestinationDBDetail> TempDestinationDBDetail { get; set; } = null!;
        public virtual DbSet<TempDestinationDBTables> TempDestinationDBTables { get; set; } = null!;
        public virtual DbSet<TempSourceDBDetail> TempSourceDBDetail { get; set; } = null!;
        public virtual DbSet<TempSysFK> TempSysFK { get; set; } = null!;
        public virtual DbSet<TempSysObj> TempSysObj { get; set; } = null!;
        public virtual DbSet<TunningIdxTmp> TunningIdxTmp { get; set; } = null!;
        public virtual DbSet<Tunning_ErroLog> Tunning_ErroLog { get; set; } = null!;
        public virtual DbSet<Tunning_InitialParameters> Tunning_InitialParameters { get; set; } = null!;
        public virtual DbSet<Tunning_Process> Tunning_Process { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Modern_Spanish_CI_AS");

            modelBuilder.Entity<Cat_Process>(entity =>
            {
                entity.Property(e => e.ID_Process).ValueGeneratedNever();
            });

            modelBuilder.Entity<DatabaseDirectory>(entity =>
            {
                entity.Property(e => e.GuidCompany).ValueGeneratedNever();
            });

            modelBuilder.Entity<EFOS>(entity =>
            {
                entity.HasIndex(e => e.No, "IXC_EFOS")
                    .IsClustered();
            });

            modelBuilder.Entity<MergeProcess>(entity =>
            {
                entity.HasIndex(e => e.GuidProcess_Merge, "IXC_MergeProcess")
                    .IsClustered();
            });

            modelBuilder.Entity<Owners>(entity =>
            {
                entity.HasOne(d => d.GuidCompanyNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.GuidCompany)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Owners");
            });

            modelBuilder.Entity<ProcessControl>(entity =>
            {
                entity.HasIndex(e => e.GuidControl, "IXFK_ProcessControl")
                    .IsClustered();

                entity.HasOne(d => d.Id_ProcessNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Id_Process)
                    .HasConstraintName("FK_CatProcess");
            });

            modelBuilder.Entity<Schema_CompaniesProgObj>(entity =>
            {
                entity.HasIndex(e => e.NameObj, "IC_MyCompanyProgObj")
                    .IsClustered();
            });

            modelBuilder.Entity<TempDestinationDBDetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TempSourceDBDetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
