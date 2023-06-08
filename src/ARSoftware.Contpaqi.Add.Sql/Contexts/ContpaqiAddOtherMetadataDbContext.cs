using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata;

namespace ARSoftware.Contpaqi.Add.Sql.Contexts
{
    public partial class ContpaqiAddOtherMetadataDbContext : DbContext
    {
        public ContpaqiAddOtherMetadataDbContext()
        {
        }

        public ContpaqiAddOtherMetadataDbContext(DbContextOptions<ContpaqiAddOtherMetadataDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Certificates> Certificates { get; set; } = null!;
        public virtual DbSet<CfdiRelacionados> CfdiRelacionados { get; set; } = null!;
        public virtual DbSet<Comprobante> Comprobante { get; set; } = null!;
        public virtual DbSet<Conceptos> Conceptos { get; set; } = null!;
        public virtual DbSet<Declaraciones> Declaraciones { get; set; } = null!;
        public virtual DbSet<Diccionario> Diccionario { get; set; } = null!;
        public virtual DbSet<DocRel_RetencionesDR_Pago> DocRel_RetencionesDR_Pago { get; set; } = null!;
        public virtual DbSet<DocRel_TrasladosDR_Pago> DocRel_TrasladosDR_Pago { get; set; } = null!;
        public virtual DbSet<Doc_App> Doc_App { get; set; } = null!;
        public virtual DbSet<DocumentRef> DocumentRef { get; set; } = null!;
        public virtual DbSet<DocumentRefPivot> DocumentRefPivot { get; set; } = null!;
        public virtual DbSet<DocumentStatus> DocumentStatus { get; set; } = null!;
        public virtual DbSet<Documento> Documento { get; set; } = null!;
        public virtual DbSet<EFOS_RFC> EFOS_RFC { get; set; } = null!;
        public virtual DbSet<EntidadSCNF> EntidadSCNF { get; set; } = null!;
        public virtual DbSet<EstatusProceso> EstatusProceso { get; set; } = null!;
        public virtual DbSet<ExpTool> ExpTool { get; set; } = null!;
        public virtual DbSet<Expedientes> Expedientes { get; set; } = null!;
        public virtual DbSet<Impuesto_Retencion> Impuesto_Retencion { get; set; } = null!;
        public virtual DbSet<Impuesto_Retencion_Concepto> Impuesto_Retencion_Concepto { get; set; } = null!;
        public virtual DbSet<Impuesto_Traslado> Impuesto_Traslado { get; set; } = null!;
        public virtual DbSet<Impuesto_Traslado_Concepto> Impuesto_Traslado_Concepto { get; set; } = null!;
        public virtual DbSet<ImpuestosTotalizados> ImpuestosTotalizados { get; set; } = null!;
        public virtual DbSet<Impuestos_Locales> Impuestos_Locales { get; set; } = null!;
        public virtual DbSet<Impuestos_Pagos> Impuestos_Pagos { get; set; } = null!;
        public virtual DbSet<Impuestos_Retencion_Pago> Impuestos_Retencion_Pago { get; set; } = null!;
        public virtual DbSet<Impuestos_Retenciones_Locales> Impuestos_Retenciones_Locales { get; set; } = null!;
        public virtual DbSet<Impuestos_Traslado_Pago> Impuestos_Traslado_Pago { get; set; } = null!;
        public virtual DbSet<Impuestos_Traslados_Locales> Impuestos_Traslados_Locales { get; set; } = null!;
        public virtual DbSet<InformacionGlobal> InformacionGlobal { get; set; } = null!;
        public virtual DbSet<MetadataDuplicados> MetadataDuplicados { get; set; } = null!;
        public virtual DbSet<MigradorLog> MigradorLog { get; set; } = null!;
        public virtual DbSet<MyCompanyProgObj> MyCompanyProgObj { get; set; } = null!;
        public virtual DbSet<Nomina> Nomina { get; set; } = null!;
        public virtual DbSet<Nomina_Detalle> Nomina_Detalle { get; set; } = null!;
        public virtual DbSet<Nomina_HorasExtras> Nomina_HorasExtras { get; set; } = null!;
        public virtual DbSet<Nomina_Incapacidad> Nomina_Incapacidad { get; set; } = null!;
        public virtual DbSet<Nomina_Subcontratacion> Nomina_Subcontratacion { get; set; } = null!;
        public virtual DbSet<Pagos> Pagos { get; set; } = null!;
        public virtual DbSet<Pagos_Doc_Rel> Pagos_Doc_Rel { get; set; } = null!;
        public virtual DbSet<Partes> Partes { get; set; } = null!;
        public virtual DbSet<Retenciones> Retenciones { get; set; } = null!;
        public virtual DbSet<RetencionesXImp> RetencionesXImp { get; set; } = null!;
        public virtual DbSet<TempAsocTool> TempAsocTool { get; set; } = null!;
        public virtual DbSet<TempAsocToolAccountingPol> TempAsocToolAccountingPol { get; set; } = null!;
        public virtual DbSet<TimbreTemp> TimbreTemp { get; set; } = null!;
        public virtual DbSet<ToolAsocDetail> ToolAsocDetail { get; set; } = null!;
        public virtual DbSet<ToolLog> ToolLog { get; set; } = null!;
        public virtual DbSet<TotalPagos> TotalPagos { get; set; } = null!;
        public virtual DbSet<XMLControl> XMLControl { get; set; } = null!;
        public virtual DbSet<cat_TipoDocumento> cat_TipoDocumento { get; set; } = null!;
        public virtual DbSet<v_Expedientes> v_Expedientes { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Modern_Spanish_CI_AS");

            modelBuilder.Entity<Certificates>(entity =>
            {
                entity.Property(e => e.GuidDocument).ValueGeneratedNever();
            });

            modelBuilder.Entity<CfdiRelacionados>(entity =>
            {
                entity.HasOne(d => d.GuidDocumentNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.GuidDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CfdiRelacionados_Comprobante");
            });

            modelBuilder.Entity<Comprobante>(entity =>
            {
                entity.HasKey(e => e.GuidDocument)
                    .HasName("PK_CFDI");

                entity.Property(e => e.GuidDocument).ValueGeneratedNever();

                entity.HasOne(d => d.GuidDocumentNavigation)
                    .WithOne(p => p.Comprobante)
                    .HasForeignKey<Comprobante>(d => d.GuidDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CFDI_Documento");
            });

            modelBuilder.Entity<Conceptos>(entity =>
            {
                entity.HasOne(d => d.GuidDocumentNavigation)
                    .WithMany(p => p.Conceptos)
                    .HasForeignKey(d => d.GuidDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Conceptos_CFDI");
            });

            modelBuilder.Entity<Declaraciones>(entity =>
            {
                entity.Property(e => e.GuidDocument).ValueGeneratedNever();

                entity.HasOne(d => d.GuidDocumentNavigation)
                    .WithOne(p => p.Declaraciones)
                    .HasForeignKey<Declaraciones>(d => d.GuidDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Declaraciones_Documento");
            });

            modelBuilder.Entity<DocRel_RetencionesDR_Pago>(entity =>
            {
                entity.HasOne(d => d.Id)
                    .WithMany()
                    .HasForeignKey(d => new { d.IdPago, d.IdDoctoUnique })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RetencionesDR_Pago");
            });

            modelBuilder.Entity<DocRel_TrasladosDR_Pago>(entity =>
            {
                entity.HasOne(d => d.Id)
                    .WithMany()
                    .HasForeignKey(d => new { d.IdPago, d.IdDoctoUnique })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrasladosDR_Pago");
            });

            modelBuilder.Entity<Doc_App>(entity =>
            {
                entity.Property(e => e.GuidDocument).ValueGeneratedNever();

                entity.HasOne(d => d.GuidDocumentNavigation)
                    .WithOne(p => p.Doc_App)
                    .HasForeignKey<Doc_App>(d => d.GuidDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Doc_App");
            });

            modelBuilder.Entity<DocumentRef>(entity =>
            {
                entity.HasIndex(e => e.GuidDocument, "IXFK_DocumentRef_Documento")
                    .IsClustered();
            });

            modelBuilder.Entity<DocumentRefPivot>(entity =>
            {
                entity.HasIndex(e => e.GuidDocument, "IXFK_DocumentRefPivot_Documento")
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Documento>(entity =>
            {
                entity.Property(e => e.GuidDocument).ValueGeneratedNever();

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.Documento)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .HasConstraintName("FK_Documento_cat_TipoDocumento");
            });

            modelBuilder.Entity<EFOS_RFC>(entity =>
            {
                entity.HasIndex(e => e.RFC, "IXC_EDOSRFC")
                    .IsClustered();
            });

            modelBuilder.Entity<EntidadSCNF>(entity =>
            {
                entity.HasOne(d => d.GuidDocumentNavigation)
                    .WithMany(p => p.EntidadSCNF)
                    .HasForeignKey(d => d.GuidDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EntidadSCNF_Nomina");
            });

            modelBuilder.Entity<EstatusProceso>(entity =>
            {
                entity.HasOne(d => d.GuidDocumentNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.GuidDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EstatusProceso_Documento");
            });

            modelBuilder.Entity<Impuesto_Retencion>(entity =>
            {
                entity.HasOne(d => d.GuidDocumentNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.GuidDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Impuesto_Retencion_Comprobante");
            });

            modelBuilder.Entity<Impuesto_Retencion_Concepto>(entity =>
            {
                entity.HasOne(d => d.IdConceptoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdConcepto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Impuesto_Retencion_Concepto_Conceptos");
            });

            modelBuilder.Entity<Impuesto_Traslado>(entity =>
            {
                entity.HasOne(d => d.GuidDocumentNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.GuidDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Impuesto_Traslado_Comprobante");
            });

            modelBuilder.Entity<Impuesto_Traslado_Concepto>(entity =>
            {
                entity.HasOne(d => d.IdConceptoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdConcepto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Impuesto_Traslado_Concepto_Conceptos");
            });

            modelBuilder.Entity<ImpuestosTotalizados>(entity =>
            {
                entity.Property(e => e.GuidDocument).ValueGeneratedNever();

                entity.HasOne(d => d.GuidDocumentNavigation)
                    .WithOne(p => p.ImpuestosTotalizados)
                    .HasForeignKey<ImpuestosTotalizados>(d => d.GuidDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImpuestosTotalizados");
            });

            modelBuilder.Entity<Impuestos_Locales>(entity =>
            {
                entity.Property(e => e.GuidDocument).ValueGeneratedNever();

                entity.HasOne(d => d.GuidDocumentNavigation)
                    .WithOne(p => p.Impuestos_Locales)
                    .HasForeignKey<Impuestos_Locales>(d => d.GuidDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Impuestos_Locales");
            });

            modelBuilder.Entity<Impuestos_Pagos>(entity =>
            {
                entity.HasOne(d => d.IdPagoNavigation)
                    .WithMany(p => p.Impuestos_Pagos)
                    .HasForeignKey(d => d.IdPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Impuestos_Pagos_Pagos");
            });

            modelBuilder.Entity<Impuestos_Retencion_Pago>(entity =>
            {
                entity.HasOne(d => d.IdImpuestoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdImpuesto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Impuesto_Retencion_Pago_Impuestos_Pagos");
            });

            modelBuilder.Entity<Impuestos_Retenciones_Locales>(entity =>
            {
                entity.HasOne(d => d.GuidDocumentNavigation)
                    .WithMany(p => p.Impuestos_Retenciones_Locales)
                    .HasForeignKey(d => d.GuidDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Impuestos_Retenciones_Locales");
            });

            modelBuilder.Entity<Impuestos_Traslado_Pago>(entity =>
            {
                entity.HasOne(d => d.IdImpuestoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdImpuesto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Impuestos_Traslado_Pago_Impuestos_Pagos");
            });

            modelBuilder.Entity<Impuestos_Traslados_Locales>(entity =>
            {
                entity.HasOne(d => d.GuidDocumentNavigation)
                    .WithMany(p => p.Impuestos_Traslados_Locales)
                    .HasForeignKey(d => d.GuidDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Impuestos_Traslados_Locales");
            });

            modelBuilder.Entity<InformacionGlobal>(entity =>
            {
                entity.HasOne(d => d.GuidDocumentNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.GuidDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Info_Global");
            });

            modelBuilder.Entity<MigradorLog>(entity =>
            {
                entity.Property(e => e.IdLog).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MyCompanyProgObj>(entity =>
            {
                entity.HasIndex(e => e.NameObj, "IC_MyCompanyProgObj")
                    .IsClustered();
            });

            modelBuilder.Entity<Nomina>(entity =>
            {
                entity.Property(e => e.GuidDocument).ValueGeneratedNever();

                entity.HasOne(d => d.GuidDocumentNavigation)
                    .WithOne(p => p.Nomina)
                    .HasForeignKey<Nomina>(d => d.GuidDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nomina_CFDI");
            });

            modelBuilder.Entity<Nomina_Detalle>(entity =>
            {
                entity.HasOne(d => d.GuidDocumentNavigation)
                    .WithMany(p => p.Nomina_Detalle)
                    .HasForeignKey(d => d.GuidDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nomina_Detalle");
            });

            modelBuilder.Entity<Nomina_HorasExtras>(entity =>
            {
                entity.HasOne(d => d.GuidDocumentNavigation)
                    .WithMany(p => p.Nomina_HorasExtras)
                    .HasForeignKey(d => d.GuidDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nomina_HorasExtras");
            });

            modelBuilder.Entity<Nomina_Incapacidad>(entity =>
            {
                entity.HasOne(d => d.GuidDocumentNavigation)
                    .WithMany(p => p.Nomina_Incapacidad)
                    .HasForeignKey(d => d.GuidDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nomina_Incapacidad");
            });

            modelBuilder.Entity<Nomina_Subcontratacion>(entity =>
            {
                entity.HasOne(d => d.GuidDocumentNavigation)
                    .WithMany(p => p.Nomina_Subcontratacion)
                    .HasForeignKey(d => d.GuidDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nomina_Subcontratacion");
            });

            modelBuilder.Entity<Pagos>(entity =>
            {
                entity.HasOne(d => d.GuidDocumentNavigation)
                    .WithMany(p => p.Pagos)
                    .HasForeignKey(d => d.GuidDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pagos_CFDI");
            });

            modelBuilder.Entity<Pagos_Doc_Rel>(entity =>
            {
                entity.HasKey(e => new { e.IdPago, e.IdDoctoUnique })
                    .HasName("PK_Pagos_Doc_Rel_Pagos");

                entity.HasOne(d => d.IdPagoNavigation)
                    .WithMany(p => p.Pagos_Doc_Rel)
                    .HasForeignKey(d => d.IdPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pagos_Doc_Rel_Pagos");
            });

            modelBuilder.Entity<Partes>(entity =>
            {
                entity.HasOne(d => d.IdConceptoNavigation)
                    .WithMany(p => p.Partes)
                    .HasForeignKey(d => d.IdConcepto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Partes_Conceptos");
            });

            modelBuilder.Entity<Retenciones>(entity =>
            {
                entity.Property(e => e.GuidDocument).ValueGeneratedNever();

                entity.HasOne(d => d.GuidDocumentNavigation)
                    .WithOne(p => p.Retenciones)
                    .HasForeignKey<Retenciones>(d => d.GuidDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Retenciones_Documento");
            });

            modelBuilder.Entity<RetencionesXImp>(entity =>
            {
                entity.HasOne(d => d.GuidDocumentNavigation)
                    .WithMany(p => p.RetencionesXImp)
                    .HasForeignKey(d => d.GuidDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RetencionesXImp_Retenciones");
            });

            modelBuilder.Entity<TimbreTemp>(entity =>
            {
                entity.Property(e => e.UUID).ValueGeneratedNever();
            });

            modelBuilder.Entity<TotalPagos>(entity =>
            {
                entity.HasOne(d => d.GuidDocumentNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.GuidDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Total_Pagos");
            });

            modelBuilder.Entity<cat_TipoDocumento>(entity =>
            {
                entity.Property(e => e.IdTipoDocumento).ValueGeneratedNever();
            });

            modelBuilder.Entity<v_Expedientes>(entity =>
            {
                entity.ToView("v_Expedientes");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
