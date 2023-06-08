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

            modelBuilder.Entity<Cat_MetaType>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.ID_Type, e.MetaType, e.DBStorage }, "IXFKNC_Cat_MetaType");

                entity.Property(e => e.DBStorage)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MetaType)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cat_Process>(entity =>
            {
                entity.HasKey(e => e.ID_Process);

                entity.HasIndex(e => e.ID_Process, "IXFK_Cat_Process");

                entity.Property(e => e.ID_Process).ValueGeneratedNever();

                entity.Property(e => e.DescripcionProcces)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Certificates>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.GuidDocument, "IXFK_Certificates");

                entity.Property(e => e.FechaFinal).HasColumnType("datetime");

                entity.Property(e => e.FechaInicial).HasColumnType("datetime");

                entity.Property(e => e.IssuerName).HasColumnType("text");

                entity.Property(e => e.LlavePublica).HasColumnType("text");

                entity.Property(e => e.NumeroSerie)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SubjectName).HasColumnType("text");
            });

            modelBuilder.Entity<DatabaseDirectory>(entity =>
            {
                entity.HasKey(e => e.GuidCompany);

                entity.HasIndex(e => new { e.GuidCompany, e.idDataBase, e.DB_DocumentsMetadata, e.DB_OthersMetadata }, "IXFKNC_DatabaseDirectory");

                entity.HasIndex(e => new { e.GuidCompany, e.idDataBase, e.DB_DocumentsContent, e.DB_OthersContent }, "IXFKNC_DatabaseDirectory2");

                entity.Property(e => e.GuidCompany).ValueGeneratedNever();

                entity.Property(e => e.Accesibility)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Alias)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyPath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DB_DocumentsContent)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DB_DocumentsMetadata)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DB_OthersContent)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DB_OthersMetadata)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NombreEmpresa)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RFC)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Syncronized).HasColumnType("datetime");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.Ver_DocumentsContent).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Ver_DocumentsMetadata).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Ver_OthersContent).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Ver_OthersMetadata).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Version)
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DocumentosDuplicados>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<EFOS>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.No, "IXC_EFOS")
                    .IsClustered();

                entity.HasIndex(e => new { e.No, e.RFC, e.Nombre }, "IXNC_EFOS");

                entity.Property(e => e.NoPublica)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumGlobContDesv)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumGlobDef)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumGlobPres)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PubDOFPresuntos).HasColumnType("datetime");

                entity.Property(e => e.PubDofDef).HasColumnType("datetime");

                entity.Property(e => e.PubDofDesvir)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PubSATDef).HasColumnType("datetime");

                entity.Property(e => e.PubSATPresuntos).HasColumnType("datetime");

                entity.Property(e => e.PubSatDesvir).HasColumnType("datetime");

                entity.Property(e => e.RFC)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Situacion)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EFOS_Version>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.URL)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MergeDocs>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.GuidProcess_Merge, e.GuidDocument, e.Storage, e.DocType, e.Operation, e.UUID }, "IXNC_MergeProcess");

                entity.HasIndex(e => new { e.GuidProcess_Merge, e.Operation, e.GuidDocument }, "NC_MergeProcess_Operation");

                entity.HasIndex(e => new { e.GuidProcess_Merge, e.GuidDocument }, "NC_Process_Document");

                entity.Property(e => e.DocType)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Storage)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MergeProcess>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.GuidProcess_Merge, "IXC_MergeProcess")
                    .IsClustered();

                entity.HasIndex(e => new { e.GuidProcess_Merge, e.GuidMigrateProcess, e.GuidCompanySource, e.GuidCompanyDestination, e.CancelMerge }, "IXNC_MergeProcess");

                entity.Property(e => e.EndDateProcess).HasColumnType("datetime");

                entity.Property(e => e.StartDateProcess).HasColumnType("datetime");
            });

            modelBuilder.Entity<Owners>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.GuidOwner, "IXFK_Owners");

                entity.Property(e => e.ApplicationType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MemberType)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.HasOne(d => d.GuidCompanyNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.GuidCompany)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Owners");
            });

            modelBuilder.Entity<ProcessControl>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.GuidControl, "IXFK_ProcessControl")
                    .IsClustered();

                entity.HasIndex(e => new { e.GuidControl, e.Id_Process, e.StatusProcess, e.TotalExtracted, e.Percentage, e.TotalProcessed }, "IXNC_ProcessControl");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.JSONName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LogName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StatusProcess)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Id_ProcessNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Id_Process)
                    .HasConstraintName("FK_CatProcess");
            });

            modelBuilder.Entity<Schema_CompaniesProgObj>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.NameObj, "IC_MyCompanyProgObj")
                    .IsClustered();

                entity.HasIndex(e => new { e.NameObj, e.Ver, e.Template }, "INC_MyCompanyProgObj");

                entity.Property(e => e.NameObj)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Ver)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.XType)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schema_CompaniesProgObj_Temp>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.NameObj)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Ver)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.XType)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schema_T_Control>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CurrentVersion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdObject)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schema_T_CurrentObjectIns>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.InsertSQLCommand).IsUnicode(false);
            });

            modelBuilder.Entity<Schema_T_DB_Inventory_Constraints>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ConstraintName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdObject)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schema_T_DB_Inventory_Constraints_Temp>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ConstraintName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdObject)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schema_T_DB_Inventory_Functions>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FunctionName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdObject)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schema_T_DB_Inventory_Functions_Temp>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FunctionName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdObject)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schema_T_DB_Inventory_SP>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdObject)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SPName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schema_T_DB_Inventory_SP_Temp>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdObject)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SPName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schema_T_DB_Inventory_Table_Detail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Xtype)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schema_T_DB_Inventory_Table_Detail_Temp>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Xtype)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schema_T_DB_Inventory_Tables>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdObject)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schema_T_DB_Inventory_Tables_Temp>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdObject)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schema_T_DB_Inventory_Views>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ViewName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schema_T_DB_Inventory_Views_Temp>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ViewName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schema_T_DB_Objects>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdObject)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schema_T_DB_Templates>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CurrentVersion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DataBaseName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schema_T_DB_TypeSpec>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DescSpec)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdSpec)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schema_T_DB_Types>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdSpec)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Xtype)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schema_T_DB_Versions>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DataBaseName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schema_T_Log>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Action)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ComponentName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DataBaseName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdObject)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempCountDocs>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<TempDestinationDBDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ColName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ColType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.TblName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempDestinationDBTables>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.TableName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempSourceDBDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ColName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ColType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.TblName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempSysFK>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<TempSysObj>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Xtype)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TunningIdxTmp>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdxName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tunning_ErroLog>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DescriptionError).IsUnicode(false);
            });

            modelBuilder.Entity<Tunning_InitialParameters>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DBTemplate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdxLevel1).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.IdxLevel2).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.IdxLevel3).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.LogLevel1).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.LogLevel2).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.LogLevel3).HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<Tunning_Process>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
