using System;
using System.Collections.Generic;
using ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Contexts;

public partial class ContpaqiAddOtherMetadataDbContext : DbContext
{
    public ContpaqiAddOtherMetadataDbContext(DbContextOptions<ContpaqiAddOtherMetadataDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Certificates> Certificates { get; set; }

    public virtual DbSet<CfdiRelacionados> CfdiRelacionados { get; set; }

    public virtual DbSet<Comprobante> Comprobante { get; set; }

    public virtual DbSet<Conceptos> Conceptos { get; set; }

    public virtual DbSet<Declaraciones> Declaraciones { get; set; }

    public virtual DbSet<Diccionario> Diccionario { get; set; }

    public virtual DbSet<DocRel_RetencionesDR_Pago> DocRel_RetencionesDR_Pago { get; set; }

    public virtual DbSet<DocRel_TrasladosDR_Pago> DocRel_TrasladosDR_Pago { get; set; }

    public virtual DbSet<Doc_App> Doc_App { get; set; }

    public virtual DbSet<DocumentRef> DocumentRef { get; set; }

    public virtual DbSet<DocumentRefPivot> DocumentRefPivot { get; set; }

    public virtual DbSet<DocumentStatus> DocumentStatus { get; set; }

    public virtual DbSet<Documento> Documento { get; set; }

    public virtual DbSet<EFOS_RFC> EFOS_RFC { get; set; }

    public virtual DbSet<EntidadSCNF> EntidadSCNF { get; set; }

    public virtual DbSet<EstatusProceso> EstatusProceso { get; set; }

    public virtual DbSet<ExpTool> ExpTool { get; set; }

    public virtual DbSet<Expedientes> Expedientes { get; set; }

    public virtual DbSet<Impuesto_Retencion> Impuesto_Retencion { get; set; }

    public virtual DbSet<Impuesto_Retencion_Concepto> Impuesto_Retencion_Concepto { get; set; }

    public virtual DbSet<Impuesto_Traslado> Impuesto_Traslado { get; set; }

    public virtual DbSet<Impuesto_Traslado_Concepto> Impuesto_Traslado_Concepto { get; set; }

    public virtual DbSet<ImpuestosTotalizados> ImpuestosTotalizados { get; set; }

    public virtual DbSet<Impuestos_Locales> Impuestos_Locales { get; set; }

    public virtual DbSet<Impuestos_Pagos> Impuestos_Pagos { get; set; }

    public virtual DbSet<Impuestos_Retencion_Pago> Impuestos_Retencion_Pago { get; set; }

    public virtual DbSet<Impuestos_Retenciones_Locales> Impuestos_Retenciones_Locales { get; set; }

    public virtual DbSet<Impuestos_Traslado_Pago> Impuestos_Traslado_Pago { get; set; }

    public virtual DbSet<Impuestos_Traslados_Locales> Impuestos_Traslados_Locales { get; set; }

    public virtual DbSet<InformacionGlobal> InformacionGlobal { get; set; }

    public virtual DbSet<MetadataDuplicados> MetadataDuplicados { get; set; }

    public virtual DbSet<MigradorLog> MigradorLog { get; set; }

    public virtual DbSet<MyCompanyProgObj> MyCompanyProgObj { get; set; }

    public virtual DbSet<Nomina> Nomina { get; set; }

    public virtual DbSet<Nomina_Detalle> Nomina_Detalle { get; set; }

    public virtual DbSet<Nomina_HorasExtras> Nomina_HorasExtras { get; set; }

    public virtual DbSet<Nomina_Incapacidad> Nomina_Incapacidad { get; set; }

    public virtual DbSet<Nomina_Subcontratacion> Nomina_Subcontratacion { get; set; }

    public virtual DbSet<Pagos> Pagos { get; set; }

    public virtual DbSet<Pagos_Doc_Rel> Pagos_Doc_Rel { get; set; }

    public virtual DbSet<Partes> Partes { get; set; }

    public virtual DbSet<Retenciones> Retenciones { get; set; }

    public virtual DbSet<RetencionesXImp> RetencionesXImp { get; set; }

    public virtual DbSet<TempAsocTool> TempAsocTool { get; set; }

    public virtual DbSet<TempAsocToolAccountingPol> TempAsocToolAccountingPol { get; set; }

    public virtual DbSet<TimbreTemp> TimbreTemp { get; set; }

    public virtual DbSet<ToolAsocDetail> ToolAsocDetail { get; set; }

    public virtual DbSet<ToolLog> ToolLog { get; set; }

    public virtual DbSet<TotalPagos> TotalPagos { get; set; }

    public virtual DbSet<XMLControl> XMLControl { get; set; }

    public virtual DbSet<cat_TipoDocumento> cat_TipoDocumento { get; set; }

    public virtual DbSet<v_Expedientes> v_Expedientes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Modern_Spanish_CI_AS");

        modelBuilder.Entity<Certificates>(entity =>
        {
            entity.HasKey(e => e.GuidDocument);

            entity.HasIndex(e => e.GuidDocument, "IXFK_Certificates");

            entity.Property(e => e.GuidDocument).ValueGeneratedNever();
            entity.Property(e => e.ActualCSDStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FechaFinal).HasColumnType("datetime");
            entity.Property(e => e.FechaInicial).HasColumnType("datetime");
            entity.Property(e => e.NumeroSerie)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CfdiRelacionados>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.GuidDocument, "IXFK_CfdiRelacionados_Comprobante");

            entity.Property(e => e.TipoRelacion)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.TipoRelacionDesc)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.GuidDocumentNavigation).WithMany()
                .HasForeignKey(d => d.GuidDocument)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CfdiRelacionados_Comprobante");
        });

        modelBuilder.Entity<Comprobante>(entity =>
        {
            entity.HasKey(e => e.GuidDocument).HasName("PK_CFDI");

            entity.HasIndex(e => new { e.GuidDocument, e.Fecha, e.UUID, e.Version }, "IXFKNC_CFDI_Documento");

            entity.HasIndex(e => e.RFCEmisor, "IXNC_EDOSRFCEM");

            entity.HasIndex(e => e.RFCReceptor, "IXNC_EDOSRFCRE");

            entity.HasIndex(e => e.UUID, "IXNC_UUID");

            entity.HasIndex(e => new { e.RFCEmisor, e.Fecha }, "NCTA_Comprobante_1");

            entity.Property(e => e.GuidDocument).ValueGeneratedNever();
            entity.Property(e => e.CURPEmisor)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CondicionesPago)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Confirmacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DomicilioReceptor)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Exportacion)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ExportacionDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaTimbrado).HasColumnType("datetime");
            entity.Property(e => e.Folio)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.FormaPago)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FormaPagoDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LugarExp).IsUnicode(false);
            entity.Property(e => e.LugarExpDesc).IsUnicode(false);
            entity.Property(e => e.MetodoPago)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MetodoPagoDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Moneda)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MonedaDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NombreEmisor)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NombreReceptor)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NumCta)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.NumRegIdTrib)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.NumeroCertificado)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.NumeroOperacion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RFCEmisor)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.RFCReceptor)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.RegimenEmisor)
                .HasMaxLength(254)
                .IsUnicode(false);
            entity.Property(e => e.RegimenEmisorDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RegimenReceptor)
                .HasMaxLength(254)
                .IsUnicode(false);
            entity.Property(e => e.RegimenReceptorDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ResidenciaFiscal)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ResidenciaFiscalDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Serie)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TipoCambio).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TipoComprobante)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TipoComprobanteDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TotImpRetenidos).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TotImpTraslado).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.UsoCFDI)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UsoCFDI_Desc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Version)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.HasOne(d => d.GuidDocumentNavigation).WithOne(p => p.Comprobante)
                .HasForeignKey<Comprobante>(d => d.GuidDocument)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CFDI_Documento");
        });

        modelBuilder.Entity<Conceptos>(entity =>
        {
            entity.HasKey(e => e.IdConcepto);

            entity.HasIndex(e => e.GuidDocument, "IXFK_Conceptos_CFDI");

            entity.Property(e => e.IdConcepto)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.ClaveUnidad)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClaveUnidadDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CveProdSer)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CveProdSerDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DomicilioFiscalCtaTercero)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.NoIdentificacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NombreCtaTercero)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.ObjetoImp)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ObjetoImpDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RFCCtaTercero)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.RegimenFiscalCtaTercero)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RegimenFiscalCtaTerceroDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Unidad)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ValorUnitario).HasColumnType("decimal(18, 6)");

            entity.HasOne(d => d.GuidDocumentNavigation).WithMany(p => p.Conceptos)
                .HasForeignKey(d => d.GuidDocument)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Conceptos_CFDI");
        });

        modelBuilder.Entity<Declaraciones>(entity =>
        {
            entity.HasKey(e => e.GuidDocument);

            entity.HasIndex(e => e.GuidDocument, "IXFK_Declaraciones_Documento");

            entity.Property(e => e.GuidDocument).ValueGeneratedNever();
            entity.Property(e => e.EmisionDateDeclaracion).HasColumnType("datetime");
            entity.Property(e => e.FileName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NumOrden)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumTramite)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.OperationNum)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PeriodDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RFC)
                .HasMaxLength(18)
                .IsUnicode(false);
            entity.Property(e => e.TipoEnvio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoSolicitud)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ValidationStatus)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.GuidDocumentNavigation).WithOne(p => p.Declaraciones)
                .HasForeignKey<Declaraciones>(d => d.GuidDocument)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Declaraciones_Documento");
        });

        modelBuilder.Entity<Diccionario>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Field)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Label)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Table)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DocRel_RetencionesDR_Pago>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.IdPago, "IXFK_RetencionesDR_Pago");

            entity.HasIndex(e => e.IdDoctoUnique, "IXFK_RetencionesDR_Pago_IdDoctoUnique");

            entity.Property(e => e.BaseDR).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.IdPago)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.ImporteDR).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.ImpuestoDR)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ImpuestoDRDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TasaOCuotaDR).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TipoFactorDR)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.Pagos_Doc_Rel).WithMany()
                .HasForeignKey(d => new { d.IdPago, d.IdDoctoUnique })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RetencionesDR_Pago");
        });

        modelBuilder.Entity<DocRel_TrasladosDR_Pago>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.IdPago, "IXFK_TrasladosDR_Pago");

            entity.HasIndex(e => e.IdDoctoUnique, "IXFK_TrasladosDR_Pago_IdDoctoUnique");

            entity.Property(e => e.BaseDR).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.IdPago)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.ImporteDR).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.ImpuestoDR)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ImpuestoDRDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TasaOCuotaDR).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TipoFactorDR)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.Pagos_Doc_Rel).WithMany()
                .HasForeignKey(d => new { d.IdPago, d.IdDoctoUnique })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TrasladosDR_Pago");
        });

        modelBuilder.Entity<Doc_App>(entity =>
        {
            entity.HasKey(e => e.GuidDocument);

            entity.HasIndex(e => e.GuidDocument, "IXFK_Doc_App");

            entity.Property(e => e.GuidDocument).ValueGeneratedNever();
            entity.Property(e => e.Cuenta)
                .HasMaxLength(36)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Folio).HasMaxLength(40);
            entity.Property(e => e.Numero).HasMaxLength(40);
            entity.Property(e => e.SubTipoNumero).HasMaxLength(40);
            entity.Property(e => e.Subtipo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.GuidDocumentNavigation).WithOne(p => p.Doc_App)
                .HasForeignKey<Doc_App>(d => d.GuidDocument)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Doc_App");
        });

        modelBuilder.Entity<DocumentRef>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.GuidDocument, e.ApplicationType, e.Comment }, "IXFKNC_DocumentRef_Documento");

            entity.HasIndex(e => e.GuidDocument, "IXFK_DocumentRef_Documento").IsClustered();

            entity.Property(e => e.AggregationType)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ApplicationType)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DocumentRefPivot>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.GuidDocument, e.ApplicationType, e.Comment }, "IXFKNC_DocumentRefPivot_Documento");

            entity.HasIndex(e => e.GuidDocument, "IXFK_DocumentRefPivot_Documento").IsClustered();

            entity.Property(e => e.AggregationType)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ApplicationType)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DocumentStatus>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.GuidDocument, "IXFK_DocumentStatus");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IdError)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LlastmodifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Documento>(entity =>
        {
            entity.HasKey(e => e.GuidDocument);

            entity.HasIndex(e => new { e.GuidDocument, e.IdTipoDocumento, e.Type }, "IXFK_Documento");

            entity.HasIndex(e => e.GuidDocument, "IXNC_SourceFile");

            entity.Property(e => e.GuidDocument).ValueGeneratedNever();
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.CancelStatus)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ClaveDescripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EmisionDate).HasColumnType("datetime");
            entity.Property(e => e.EndPeriodDate).HasColumnType("datetime");
            entity.Property(e => e.Hash)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MetadataEstatusApp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NoPaymentStatusapp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Path)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ProcessApp)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SalaryType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SourceFile)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.StartPeriodDate).HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            entity.Property(e => e.TotalPayRoll).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Type_Ext)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Type_Otro)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UserResponsibleApp)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ValidationStatus)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.IdTipoDocumentoNavigation).WithMany(p => p.Documento)
                .HasForeignKey(d => d.IdTipoDocumento)
                .HasConstraintName("FK_Documento_cat_TipoDocumento");
        });

        modelBuilder.Entity<EFOS_RFC>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.RFC, "IXC_EDOSRFC").IsClustered();

            entity.Property(e => e.RFC)
                .HasMaxLength(13)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EntidadSCNF>(entity =>
        {
            entity.HasKey(e => e.IdEntidadSCNF);

            entity.HasIndex(e => new { e.GuidDocument, e.IdEntidadSCNF }, "IXFKNC_EntidadSCNF_Nomina");

            entity.Property(e => e.IdEntidadSCNF)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.MontoRecursoPropio).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.OrigenRecurso)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.OrigenRecursoDesc)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.GuidDocumentNavigation).WithMany(p => p.EntidadSCNF)
                .HasForeignKey(d => d.GuidDocument)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EntidadSCNF_Nomina");
        });

        modelBuilder.Entity<EstatusProceso>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.GuidDocument, "IXFK_EstatusProceso_Documento");

            entity.Property(e => e.Comentario)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Timestamp).HasColumnType("datetime");

            entity.HasOne(d => d.GuidDocumentNavigation).WithMany()
                .HasForeignKey(d => d.GuidDocument)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EstatusProceso_Documento");
        });

        modelBuilder.Entity<ExpTool>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<Expedientes>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.Guid_Relacionado, "IXFK_Expedientes_Documento");

            entity.HasIndex(e => e.Guid_Pertenece, "NC_Expedientes_GuidPertenece");

            entity.Property(e => e.ApplicationType_Exp)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Comment_Exp)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TimeStamp_Exp).HasColumnType("datetime");
            entity.Property(e => e.Type_Exp)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Impuesto_Retencion>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.GuidDocument, "IXFK_Impuesto_Retencion_Comprobante");

            entity.Property(e => e.Importe).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Impuesto)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ImpuestoDesc)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.GuidDocumentNavigation).WithMany()
                .HasForeignKey(d => d.GuidDocument)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Impuesto_Retencion_Comprobante");
        });

        modelBuilder.Entity<Impuesto_Retencion_Concepto>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.IdConcepto, "IXFK_Impuesto_Retencion_Concepto_Conceptos");

            entity.Property(e => e.Base).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.IdConcepto)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Impuesto)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ImpuestoDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TasaOCuota)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.TipoFactor)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.IdConceptoNavigation).WithMany()
                .HasForeignKey(d => d.IdConcepto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Impuesto_Retencion_Concepto_Conceptos");
        });

        modelBuilder.Entity<Impuesto_Traslado>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.GuidDocument, "IXFK_Impuesto_Traslado_Comprobante");

            entity.Property(e => e.Importe).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Impuesto)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ImpuestoDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TasaOCuota)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.TipoFactor)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.GuidDocumentNavigation).WithMany()
                .HasForeignKey(d => d.GuidDocument)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Impuesto_Traslado_Comprobante");
        });

        modelBuilder.Entity<Impuesto_Traslado_Concepto>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.IdConcepto, "IXFK_Impuesto_Traslado_Concepto_Conceptos");

            entity.Property(e => e.Base).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.IdConcepto)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Impuesto)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ImpuestoDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TasaOCuota)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.TipoFactor)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.IdConceptoNavigation).WithMany()
                .HasForeignKey(d => d.IdConcepto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Impuesto_Traslado_Concepto_Conceptos");
        });

        modelBuilder.Entity<ImpuestosTotalizados>(entity =>
        {
            entity.HasKey(e => e.GuidDocument);

            entity.HasIndex(e => e.GuidDocument, "IXFK_ImpuestosTotalizados");

            entity.Property(e => e.GuidDocument).ValueGeneratedNever();
            entity.Property(e => e.IEPSRetenido).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ISRTrasladado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ImporteTotalIEPSTraslado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ImporteTotalISRRetenido).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ImporteTotalIVARetenido).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ImporteTotalIVATraslado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalImpuestosRetenidos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalImpuestosTrasladados).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.GuidDocumentNavigation).WithOne(p => p.ImpuestosTotalizados)
                .HasForeignKey<ImpuestosTotalizados>(d => d.GuidDocument)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImpuestosTotalizados");
        });

        modelBuilder.Entity<Impuestos_Locales>(entity =>
        {
            entity.HasKey(e => e.GuidDocument);

            entity.HasIndex(e => e.GuidDocument, "IXFK_Impuestos_Locales");

            entity.Property(e => e.GuidDocument).ValueGeneratedNever();
            entity.Property(e => e.TotalRetenciones).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TotalTraslados).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Version).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.GuidDocumentNavigation).WithOne(p => p.Impuestos_Locales)
                .HasForeignKey<Impuestos_Locales>(d => d.GuidDocument)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Impuestos_Locales");
        });

        modelBuilder.Entity<Impuestos_Pagos>(entity =>
        {
            entity.HasKey(e => e.IdImpuesto);

            entity.HasIndex(e => e.GuidDocument, "IXFK_Impuestos_Pagos_Pagos");

            entity.Property(e => e.IdImpuesto)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.IdPago)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.TotalImpuestosRetenidos).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TotalImpuestosTrasladados).HasColumnType("decimal(18, 6)");

            entity.HasOne(d => d.IdPagoNavigation).WithMany(p => p.Impuestos_Pagos)
                .HasForeignKey(d => d.IdPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Impuestos_Pagos_Pagos");
        });

        modelBuilder.Entity<Impuestos_Retencion_Pago>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.GuidDocument, "IXFK_Impuesto_Retencion_Pago_Pagos");

            entity.Property(e => e.IdImpuesto)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Impuesto)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ImpuestoDesc)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.IdImpuestoNavigation).WithMany()
                .HasForeignKey(d => d.IdImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Impuesto_Retencion_Pago_Impuestos_Pagos");
        });

        modelBuilder.Entity<Impuestos_Retenciones_Locales>(entity =>
        {
            entity.HasKey(e => e.ImpDetalle);

            entity.HasIndex(e => e.GuidDocument, "IXFK_Impuestos_Retenciones_Locales");

            entity.Property(e => e.ImpDetalle)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.ImpLocalRetenido)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ImporteRetenido).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TasadeRetencion).HasColumnType("decimal(18, 6)");

            entity.HasOne(d => d.GuidDocumentNavigation).WithMany(p => p.Impuestos_Retenciones_Locales)
                .HasForeignKey(d => d.GuidDocument)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Impuestos_Retenciones_Locales");
        });

        modelBuilder.Entity<Impuestos_Traslado_Pago>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.GuidDocument, "IXFK_Impuestos_Traslado_Pago_Pagos");

            entity.Property(e => e.IdImpuesto)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Impuesto)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ImpuestoDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TasaOCuota)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.TipoFactor)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.IdImpuestoNavigation).WithMany()
                .HasForeignKey(d => d.IdImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Impuestos_Traslado_Pago_Impuestos_Pagos");
        });

        modelBuilder.Entity<Impuestos_Traslados_Locales>(entity =>
        {
            entity.HasKey(e => e.ImpDetalle);

            entity.HasIndex(e => e.GuidDocument, "IXFK_Impuestos_Traslados_Locales");

            entity.Property(e => e.ImpDetalle)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.ImpLocalTrasladado)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ImporteTraslado).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TasadeTraslado).HasColumnType("decimal(18, 6)");

            entity.HasOne(d => d.GuidDocumentNavigation).WithMany(p => p.Impuestos_Traslados_Locales)
                .HasForeignKey(d => d.GuidDocument)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Impuestos_Traslados_Locales");
        });

        modelBuilder.Entity<InformacionGlobal>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.GuidDocument, "IXFK_Info_Global");

            entity.Property(e => e.Meses)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MesesDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Periodicidad)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PeriodicidadDesc)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.GuidDocumentNavigation).WithMany()
                .HasForeignKey(d => d.GuidDocument)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Info_Global");
        });

        modelBuilder.Entity<MetadataDuplicados>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.EndPeriodDate).HasColumnType("datetime");
            entity.Property(e => e.MetadataEstatusApp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcessApp)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SalaryType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StartPeriodDate).HasColumnType("datetime");
            entity.Property(e => e.TotalPayRoll).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.UserResponsibleApp)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MigradorLog>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ErrorMessage).IsUnicode(false);
            entity.Property(e => e.FileName).IsUnicode(false);
            entity.Property(e => e.IdLog).ValueGeneratedOnAdd();
            entity.Property(e => e.Origen)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MyCompanyProgObj>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.NameObj, "IC_MyCompanyProgObj").IsClustered();

            entity.HasIndex(e => new { e.NameObj, e.Ver }, "INC_MyCompanyProgObj");

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

        modelBuilder.Entity<Nomina>(entity =>
        {
            entity.HasKey(e => e.GuidDocument);

            entity.HasIndex(e => e.GuidDocument, "IXFK_Nomina");

            entity.Property(e => e.GuidDocument).ValueGeneratedNever();
            entity.Property(e => e.Antiguedad)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Banco)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.BancoDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CURPReceptor)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ClaveEntFed)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ClaveEntFedDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CuentaBancaria)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.DepartamentoRec)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaFinalPago).HasColumnType("datetime");
            entity.Property(e => e.FechaInicialPago).HasColumnType("datetime");
            entity.Property(e => e.FechaInicioRelLaboral).HasColumnType("datetime");
            entity.Property(e => e.FechaPago).HasColumnType("datetime");
            entity.Property(e => e.IngresoAcumulable).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.IngresoNoAcumulable).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.NumDiasPagados).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.NumEmpleadoRec)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.NumSeguridadSocialRec)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.PeriodicidadPago)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PeriodicidadPagoDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PuestoRec)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RegistroPatronal)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RemanenteSalFav).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.RiesgoPuesto)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RiesgoPuestoDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SalarioBaseCotApor).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SalarioDiarioIntegrado).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.SaldoAFavor).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Sindicalizado)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.SubsidioCausado).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TipoContrato)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TipoContratoDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TipoJornada)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.TipoJornadaDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TipoNomina)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TipoNominaDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TipoRegimen)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TipoRegimenDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TotalDeducciones).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TotalExentoDeduccion).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TotalExentoPercepcion).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TotalGravadoDeduccion).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TotalGravadoPercepcion).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TotalImpuestosRetenidos).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TotalOtrasDeducciones).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TotalOtrosPagos).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TotalPagado).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TotalPercepciones).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TotalSeparacionIndemnizacion).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TotalSueldos).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.UltimoSueldoMesOrd).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Version)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.HasOne(d => d.GuidDocumentNavigation).WithOne(p => p.Nomina)
                .HasForeignKey<Nomina>(d => d.GuidDocument)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Nomina_CFDI");
        });

        modelBuilder.Entity<Nomina_Detalle>(entity =>
        {
            entity.HasKey(e => e.IdDetalle);

            entity.HasIndex(e => e.GuidDocument, "IXFK_Nomina_Detalle_Nomina");

            entity.Property(e => e.IdDetalle)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Clave)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Concepto)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.ImporteExento).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.ImporteGravado).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TipoDetalle)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TipoDetalleDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TipoNominaDetalle)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.HasOne(d => d.GuidDocumentNavigation).WithMany(p => p.Nomina_Detalle)
                .HasForeignKey(d => d.GuidDocument)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Nomina_Detalle");
        });

        modelBuilder.Entity<Nomina_HorasExtras>(entity =>
        {
            entity.HasKey(e => e.IdHoraExtra);

            entity.HasIndex(e => e.IdDetalle, "IXFK_Nomina_HorasExtras");

            entity.Property(e => e.IdHoraExtra)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Dias).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.HorasExtra).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.IdDetalle)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TiposHoras)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TiposHoras_Desc)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.GuidDocumentNavigation).WithMany(p => p.Nomina_HorasExtras)
                .HasForeignKey(d => d.GuidDocument)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Nomina_HorasExtras");
        });

        modelBuilder.Entity<Nomina_Incapacidad>(entity =>
        {
            entity.HasKey(e => e.IdIncapacidad);

            entity.HasIndex(e => new { e.GuidDocument, e.IdIncapacidad }, "IXFKNC_Nomina_Incapacidad");

            entity.Property(e => e.IdIncapacidad)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Dias).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TipoIncapacidad)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TipoIncapacidad_Desc)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.GuidDocumentNavigation).WithMany(p => p.Nomina_Incapacidad)
                .HasForeignKey(d => d.GuidDocument)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Nomina_Incapacidad");
        });

        modelBuilder.Entity<Nomina_Subcontratacion>(entity =>
        {
            entity.HasKey(e => e.IdSub);

            entity.HasIndex(e => new { e.GuidDocument, e.IdSub }, "IXFKNC_Nomina_ISubcontratacion");

            entity.Property(e => e.IdSub)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.PorcTiempo).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.RFCLabora)
                .HasMaxLength(13)
                .IsUnicode(false);

            entity.HasOne(d => d.GuidDocumentNavigation).WithMany(p => p.Nomina_Subcontratacion)
                .HasForeignKey(d => d.GuidDocument)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Nomina_Subcontratacion");
        });

        modelBuilder.Entity<Pagos>(entity =>
        {
            entity.HasKey(e => e.IdPago);

            entity.HasIndex(e => e.GuidDocument, "IXFK_Pagos_CFDI");

            entity.Property(e => e.IdPago)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.CtaBeneficiario)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CtaOrdenante)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaPago).HasColumnType("datetime");
            entity.Property(e => e.FormaDePagoP)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FormaDePagoPDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MonedaP)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MonedaPDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.NomBancoOrdExt)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.NumOperacion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RfcEmisorCtaBen)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.RfcEmisorCtaOrd)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TipoCadPago)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TipoCadPagoDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TipoCambioP).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Version)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.HasOne(d => d.GuidDocumentNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.GuidDocument)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pagos_CFDI");
        });

        modelBuilder.Entity<Pagos_Doc_Rel>(entity =>
        {
            entity.HasKey(e => new { e.IdPago, e.IdDoctoUnique }).HasName("PK_Pagos_Doc_Rel_Pagos");

            entity.HasIndex(e => e.GuidDocument, "IXFK_Pagos_Doc_Rel_Pagos");

            entity.HasIndex(e => e.IdDoctoUnique, "IXFK_Pagos_Doc_Rel_Pagos_IdDoctoUnique");

            entity.HasIndex(e => e.IdPago, "IXFK_Pagos_Doc_Rel_Pagos_IdPago");

            entity.Property(e => e.IdPago)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.EquivalenciaDR).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Folio)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.IdDocumento)
                .HasMaxLength(36)
                .IsUnicode(false);
            entity.Property(e => e.ImpPagado).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.ImpSaldoAnt).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.ImpSaldoInsoluto).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.MetodoDePagoDR)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MetodoDePagoDRDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MonedaDR)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MonedaDRDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ObjetoImpDR)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ObjetoImpDRDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Serie)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.TipoCambioDR).HasColumnType("decimal(18, 6)");

            entity.HasOne(d => d.IdPagoNavigation).WithMany(p => p.Pagos_Doc_Rel)
                .HasForeignKey(d => d.IdPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pagos_Doc_Rel_Pagos");
        });

        modelBuilder.Entity<Partes>(entity =>
        {
            entity.HasKey(e => e.IdParte);

            entity.HasIndex(e => e.IdConcepto, "IXFK_Partes_Conceptos");

            entity.Property(e => e.IdParte)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.CveProdSer)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.CveProdSerDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.IdConcepto)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.NoIdentificacion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Unidad)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ValorUnitario).HasColumnType("decimal(18, 6)");

            entity.HasOne(d => d.IdConceptoNavigation).WithMany(p => p.Partes)
                .HasForeignKey(d => d.IdConcepto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Partes_Conceptos");
        });

        modelBuilder.Entity<Retenciones>(entity =>
        {
            entity.HasKey(e => e.GuidDocument);

            entity.HasIndex(e => new { e.GuidDocument, e.UUID }, "IXFKNC_Retenciones_Documento");

            entity.Property(e => e.GuidDocument).ValueGeneratedNever();
            entity.Property(e => e.CURPE)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CURPR)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CveRetenc)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DescRetenc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DomicilioReceptor)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FechaExp).HasColumnType("datetime");
            entity.Property(e => e.Folio)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ISRCorrespondiente).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.LugarExp)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LugarExpDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MontoTotExent).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.MontoTotGrav).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.MontoTotOperacion).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.MontoTotRet).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NomDenRazSocE)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.NomDenRazSocR)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.NomDenRazSocRExt)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.NumCert)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NumRegIdTrib)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RFCEmisor)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.RFCRecep)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.RegimenEmisor)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RegimenEmisorDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TipoRelacion)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TipoRelacionDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UtilidadBimestral).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Version)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.GuidDocumentNavigation).WithOne(p => p.Retenciones)
                .HasForeignKey<Retenciones>(d => d.GuidDocument)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Retenciones_Documento");
        });

        modelBuilder.Entity<RetencionesXImp>(entity =>
        {
            entity.HasKey(e => e.IdImpuestoRet);

            entity.HasIndex(e => e.GuidDocument, "IXFK_RetencionesXImp_Retenciones");

            entity.Property(e => e.IdImpuestoRet)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.BaseRet).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Impuesto)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ImpuestoDesc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TipoPagoRet)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.montoRet).HasColumnType("decimal(18, 6)");

            entity.HasOne(d => d.GuidDocumentNavigation).WithMany(p => p.RetencionesXImp)
                .HasForeignKey(d => d.GuidDocument)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RetencionesXImp_Retenciones");
        });

        modelBuilder.Entity<TempAsocTool>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Cuenta)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Folio).HasMaxLength(40);
            entity.Property(e => e.GuidRef).HasMaxLength(36);
            entity.Property(e => e.Sistema)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.TipoCheq)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.TipoPol).HasMaxLength(220);
            entity.Property(e => e.UUID).HasMaxLength(36);
        });

        modelBuilder.Entity<TempAsocToolAccountingPol>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.GuidRef).HasMaxLength(36);
        });

        modelBuilder.Entity<TimbreTemp>(entity =>
        {
            entity.HasKey(e => e.UUID);

            entity.Property(e => e.UUID).ValueGeneratedNever();
        });

        modelBuilder.Entity<ToolAsocDetail>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<ToolLog>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DetalleOperacion).IsUnicode(false);
            entity.Property(e => e.FechaEjecucion)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FechaFinEjecucion)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.NombreEmpresa).IsUnicode(false);
            entity.Property(e => e.Operacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RFC)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.RangoFechas)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TotalPagos>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.GuidDocument, "IXFK_Total_Pagos");

            entity.Property(e => e.MontoTotalPagos).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TotalRetencionesIEPS).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TotalRetencionesISR).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TotalRetencionesIVA).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TotalTrasladoBaseIVA0).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TotalTrasladoBaseIVA16).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TotalTrasladoBaseIVA8).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TotalTrasladoBaseIVAExento).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TotalTrasladoImpuestoIVA0).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TotalTrasladoImpuestoIVA16).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TotalTrasladoImpuestoIVA8).HasColumnType("decimal(18, 6)");

            entity.HasOne(d => d.GuidDocumentNavigation).WithMany()
                .HasForeignKey(d => d.GuidDocument)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Total_Pagos");
        });

        modelBuilder.Entity<XMLControl>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<cat_TipoDocumento>(entity =>
        {
            entity.HasKey(e => e.IdTipoDocumento);

            entity.HasIndex(e => new { e.IdTipoDocumento, e.Descripcion }, "IXFKNC_Documento_cat_TipoDocumento");

            entity.Property(e => e.IdTipoDocumento).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<v_Expedientes>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Expedientes");

            entity.Property(e => e.ApplicationType_Exp)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Comment_Exp)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TimeStamp_Exp).HasColumnType("datetime");
            entity.Property(e => e.Type_Exp)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
