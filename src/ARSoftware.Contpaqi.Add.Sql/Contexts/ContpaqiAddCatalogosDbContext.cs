using System;
using System.Collections.Generic;
using ARSoftware.Contpaqi.Add.Sql.Models.Catalogos;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Contexts;

public partial class ContpaqiAddCatalogosDbContext : DbContext
{
    public ContpaqiAddCatalogosDbContext(DbContextOptions<ContpaqiAddCatalogosDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Control> Control { get; set; }

    public virtual DbSet<c_Aduanas> c_Aduanas { get; set; }

    public virtual DbSet<c_Banco> c_Banco { get; set; }

    public virtual DbSet<c_CFDIBancoR> c_CFDIBancoR { get; set; }

    public virtual DbSet<c_CatCodMoneda> c_CatCodMoneda { get; set; }

    public virtual DbSet<c_ClaveProdSTCC> c_ClaveProdSTCC { get; set; }

    public virtual DbSet<c_ClaveProdServ> c_ClaveProdServ { get; set; }

    public virtual DbSet<c_ClaveProdServCP> c_ClaveProdServCP { get; set; }

    public virtual DbSet<c_ClaveTipoCarga> c_ClaveTipoCarga { get; set; }

    public virtual DbSet<c_ClaveUnidad> c_ClaveUnidad { get; set; }

    public virtual DbSet<c_CodAgrup> c_CodAgrup { get; set; }

    public virtual DbSet<c_CodigoPostal> c_CodigoPostal { get; set; }

    public virtual DbSet<c_CodigoTransporteAereo> c_CodigoTransporteAereo { get; set; }

    public virtual DbSet<c_ConceptoPago> c_ConceptoPago { get; set; }

    public virtual DbSet<c_ConfigAutoTransporte> c_ConfigAutoTransporte { get; set; }

    public virtual DbSet<c_ConfigMaritima> c_ConfigMaritima { get; set; }

    public virtual DbSet<c_Contenedor> c_Contenedor { get; set; }

    public virtual DbSet<c_ContenedorMaritimo> c_ContenedorMaritimo { get; set; }

    public virtual DbSet<c_CveTipDivOUtil> c_CveTipDivOUtil { get; set; }

    public virtual DbSet<c_CveTransporte> c_CveTransporte { get; set; }

    public virtual DbSet<c_DerechosDePaso> c_DerechosDePaso { get; set; }

    public virtual DbSet<c_DocumentoAduanero> c_DocumentoAduanero { get; set; }

    public virtual DbSet<c_Estado> c_Estado { get; set; }

    public virtual DbSet<c_Exportacion> c_Exportacion { get; set; }

    public virtual DbSet<c_FormaPago> c_FormaPago { get; set; }

    public virtual DbSet<c_Impuesto> c_Impuesto { get; set; }

    public virtual DbSet<c_MaterialPeligroso> c_MaterialPeligroso { get; set; }

    public virtual DbSet<c_Meses> c_Meses { get; set; }

    public virtual DbSet<c_MetPag> c_MetPag { get; set; }

    public virtual DbSet<c_MetodoPago> c_MetodoPago { get; set; }

    public virtual DbSet<c_Moneda> c_Moneda { get; set; }

    public virtual DbSet<c_ObjetoImp> c_ObjetoImp { get; set; }

    public virtual DbSet<c_OrigenRecurso> c_OrigenRecurso { get; set; }

    public virtual DbSet<c_Pais> c_Pais { get; set; }

    public virtual DbSet<c_ParteTransporte> c_ParteTransporte { get; set; }

    public virtual DbSet<c_Periodicidad> c_Periodicidad { get; set; }

    public virtual DbSet<c_PeriodicidadPago> c_PeriodicidadPago { get; set; }

    public virtual DbSet<c_PeriodicidadRetenciones> c_PeriodicidadRetenciones { get; set; }

    public virtual DbSet<c_Regimen> c_Regimen { get; set; }

    public virtual DbSet<c_RegimenAduanero> c_RegimenAduanero { get; set; }

    public virtual DbSet<c_RegimenFiscal> c_RegimenFiscal { get; set; }

    public virtual DbSet<c_RegistroISTMO> c_RegistroISTMO { get; set; }

    public virtual DbSet<c_Retenciones> c_Retenciones { get; set; }

    public virtual DbSet<c_RetencionesImpuestos> c_RetencionesImpuestos { get; set; }

    public virtual DbSet<c_RiesgoPuesto> c_RiesgoPuesto { get; set; }

    public virtual DbSet<c_SubTipoRem> c_SubTipoRem { get; set; }

    public virtual DbSet<c_TipoAportODep> c_TipoAportODep { get; set; }

    public virtual DbSet<c_TipoCadena> c_TipoCadena { get; set; }

    public virtual DbSet<c_TipoCarro> c_TipoCarro { get; set; }

    public virtual DbSet<c_TipoContrato> c_TipoContrato { get; set; }

    public virtual DbSet<c_TipoDeComprobante> c_TipoDeComprobante { get; set; }

    public virtual DbSet<c_TipoDeServicio> c_TipoDeServicio { get; set; }

    public virtual DbSet<c_TipoDeTrafico> c_TipoDeTrafico { get; set; }

    public virtual DbSet<c_TipoDeduccion> c_TipoDeduccion { get; set; }

    public virtual DbSet<c_TipoEmbalaje> c_TipoEmbalaje { get; set; }

    public virtual DbSet<c_TipoEstacion> c_TipoEstacion { get; set; }

    public virtual DbSet<c_TipoHoras> c_TipoHoras { get; set; }

    public virtual DbSet<c_TipoIncapacidad> c_TipoIncapacidad { get; set; }

    public virtual DbSet<c_TipoJornada> c_TipoJornada { get; set; }

    public virtual DbSet<c_TipoNomina> c_TipoNomina { get; set; }

    public virtual DbSet<c_TipoOtroPago> c_TipoOtroPago { get; set; }

    public virtual DbSet<c_TipoPercepcion> c_TipoPercepcion { get; set; }

    public virtual DbSet<c_TipoPermiso> c_TipoPermiso { get; set; }

    public virtual DbSet<c_TipoRelacion> c_TipoRelacion { get; set; }

    public virtual DbSet<c_TipoRiesgo> c_TipoRiesgo { get; set; }

    public virtual DbSet<c_UnidadAduana> c_UnidadAduana { get; set; }

    public virtual DbSet<c_UsoCfdi> c_UsoCfdi { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Modern_Spanish_CI_AS");

        modelBuilder.Entity<Control>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.IdCatalogo, e.Catalogo, e.Storage }, "IX_Control").IsClustered();

            entity.Property(e => e.Catalogo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.FechaLanzamiento).HasColumnType("datetime");
            entity.Property(e => e.IdCatalogo).ValueGeneratedOnAdd();
            entity.Property(e => e.Storage)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.TagReporting)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Version)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_Aduanas>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_Aduanas");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_Aduanas");

            entity.HasIndex(e => e.Codigo, "IX_c_Aduanas").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_Banco>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_Banco");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_Banco");

            entity.HasIndex(e => e.Codigo, "IX_Banco").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_CFDIBancoR>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_CFDIBancoR");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_CFDIBancoR");

            entity.HasIndex(e => e.Codigo, "IX_c_CFDIBancoR").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_CatCodMoneda>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_CatCodMoneda");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_CatCodMoneda");

            entity.HasIndex(e => e.Codigo, "IX_c_CatCodMoneda").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_ClaveProdSTCC>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_ClaveProdSTCC");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_ClaveProdSTCC");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_ClaveProdServ>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_ClaveProdServ");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_ClaveProdServ");

            entity.HasIndex(e => e.Codigo, "IX_ClaveProdServ").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_ClaveProdServCP>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_ClaveProdServCP");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_ClaveProdServCP");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_ClaveTipoCarga>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_ClaveTipoCarga");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_ClaveTipoCarga");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_ClaveUnidad>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_ClaveUnidad");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_ClaveUnidad");

            entity.HasIndex(e => e.Codigo, "IX_ClaveUnidad").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_CodAgrup>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_CodAgrup");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_CodAgrup");

            entity.HasIndex(e => e.Codigo, "IX_c_CodAgrup").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_CodigoPostal>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_CodigoPostal");

            entity.HasIndex(e => e.Codigo, "IX_CodigoPostal").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_CodigoTransporteAereo>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_CodigoTransporteAereo");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_CodigoTransporteAereo");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_ConceptoPago>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_ConceptoPago");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_ConceptoPago");

            entity.HasIndex(e => e.Codigo, "IX_c_ConceptoPago").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_ConfigAutoTransporte>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_ConfigAutoTransporte");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_ConfigAutoTransporte");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_ConfigMaritima>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_ConfigMaritima");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_ConfigMaritima");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_Contenedor>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_Contenedor");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_Contenedor");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_ContenedorMaritimo>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_ContenedorMaritimo");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_ContenedorMaritimo");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_CveTipDivOUtil>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_CveTipDivOUtil");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_CveTipDivOUtil");

            entity.HasIndex(e => e.Codigo, "IX_c_CveTipDivOUtil").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_CveTransporte>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_CveTransporte");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_CveTransporte");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_DerechosDePaso>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_DerechosDePaso");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_DerechosDePaso");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_DocumentoAduanero>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_DocumentoAduanero");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_DocumentoAduanero");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_Estado>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_Estado");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_Estado");

            entity.HasIndex(e => e.Codigo, "IX_Estado").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_Exportacion>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_Exportacion");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_Exportacion");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_FormaPago>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_FormaPago");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_FormaPago");

            entity.HasIndex(e => e.Codigo, "IX_FormaPago").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_Impuesto>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_Impuesto");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_Impuesto");

            entity.HasIndex(e => e.Codigo, "IX_Impuesto").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_MaterialPeligroso>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_MaterialPeligroso");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_MaterialPeligroso");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(512)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_Meses>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_Meses");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_Meses");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_MetPag>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_MetPag");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_MetPag");

            entity.HasIndex(e => e.Codigo, "IX_c_MetPag").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_MetodoPago>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_MetodoPago");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_MetodoPago");

            entity.HasIndex(e => e.Codigo, "IX_MetodoPago").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_Moneda>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_Moneda");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_Moneda");

            entity.HasIndex(e => e.Codigo, "IX_Moneda").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_ObjetoImp>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_ObjetoImp");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_ObjetoImp");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_OrigenRecurso>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_OrigenRecurso");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_OrigenRecurso");

            entity.HasIndex(e => e.Codigo, "IX_OrigenRecurso").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_Pais>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_Pais");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_Pais");

            entity.HasIndex(e => e.Codigo, "IX_Pais").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_ParteTransporte>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_ParteTransporte");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_ParteTransporte");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_Periodicidad>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_Periodicidad");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_Periodicidad");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_PeriodicidadPago>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_PeriodicidadPago");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_PeriodicidadPago");

            entity.HasIndex(e => e.Codigo, "IX_PeriodicidadPago").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_PeriodicidadRetenciones>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_Regimen>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_Regimen");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_Regimen");

            entity.HasIndex(e => e.Codigo, "IX_Regimen").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_RegimenAduanero>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_RegimenAduanero");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_RegimenAduanero");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_RegimenFiscal>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_RegimenFiscal");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_RegimenFiscal");

            entity.HasIndex(e => e.Codigo, "IX_RegimenFiscal").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_RegistroISTMO>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_RegistroISTMO");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_RegistroISTMO");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_Retenciones>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_Retencion");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_Retencion");

            entity.HasIndex(e => e.Codigo, "IX_Retencion").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_RetencionesImpuestos>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_RetencionesImpuestos");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_RetencionesImpuestos");

            entity.HasIndex(e => e.Codigo, "IX_RetencionesImpuestos").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_RiesgoPuesto>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_RiesgoPuesto");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_RiesgoPuesto");

            entity.HasIndex(e => e.Codigo, "IX_RiesgoPuesto").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_SubTipoRem>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_SubTipoRem");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_SubTipoRem");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_TipoAportODep>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_CatPlanesDeRetiro");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_CatPlanesDeRetiro");

            entity.HasIndex(e => e.Codigo, "IX_CatPlanesDeRetiro").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_TipoCadena>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_TipoCadena");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_TipoCadena");

            entity.HasIndex(e => e.Codigo, "IX_TipoCadena").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_TipoCarro>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_TipoCarro");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_TipoCarro");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_TipoContrato>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_TipoContrato");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_TipoContrato");

            entity.HasIndex(e => e.Codigo, "IX_TipoContrato").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_TipoDeComprobante>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_TipoDeComprobante");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_TipoDeComprobante");

            entity.HasIndex(e => e.Codigo, "IX_TipoDeComprobante").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_TipoDeServicio>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_TipoDeServicio");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_TipoDeServicio");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_TipoDeTrafico>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_TipoDeTrafico");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_TipoDeTrafico");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_TipoDeduccion>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_TipoDeduccion");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_TipoDeduccion");

            entity.HasIndex(e => e.Codigo, "IX_TipoDeduccion").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_TipoEmbalaje>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_TipoEmbalaje");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_TipoEmbalaje");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_TipoEstacion>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_TipoEstacion");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_TipoEstacion");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_TipoHoras>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_TipoHoras");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_TipoHoras");

            entity.HasIndex(e => e.Codigo, "IX_TipoHoras").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_TipoIncapacidad>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_TipoIncapacidad");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_TipoIncapacidad");

            entity.HasIndex(e => e.Codigo, "IX_TipoIncapacidad").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_TipoJornada>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_TipoJornada");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_TipoJornada");

            entity.HasIndex(e => e.Codigo, "IX_TipoJornada").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_TipoNomina>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_TipoNomina");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_TipoNomina");

            entity.HasIndex(e => e.Codigo, "IX_TipoNomina").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_TipoOtroPago>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_TipoOtroPago");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_TipoOtroPago");

            entity.HasIndex(e => e.Codigo, "IX_TipoOtroPago").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_TipoPercepcion>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_TipoPercepcion");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_TipoPercepcion");

            entity.HasIndex(e => e.Codigo, "IX_TipoPercepcion").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_TipoPermiso>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_TipoPermiso");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_TipoPermiso");

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_TipoRelacion>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_TipoRelacion");

            entity.HasIndex(e => e.Codigo, "IXNC_TipoRelacion");

            entity.HasIndex(e => e.Codigo, "IX_TipoRelacion").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_TipoRiesgo>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_TipoRiesgo");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_TipoRiesgo");

            entity.HasIndex(e => e.Codigo, "IX_TipoRiesgo").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_UnidadAduana>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_c_UnidadAduana");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_c_UnidadAduana");

            entity.HasIndex(e => e.Codigo, "IX_c_UnidadAduana").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<c_UsoCfdi>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.CodigoReporting, e.Valor }, "IXNCR_UsoCfdi");

            entity.HasIndex(e => new { e.Codigo, e.Valor }, "IXNC_UsoCfdi");

            entity.HasIndex(e => e.Codigo, "IX_UsoCfdi").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoReporting)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia).HasColumnType("datetime");
            entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            entity.Property(e => e.InicioVigencia).HasColumnType("datetime");
            entity.Property(e => e.Valor)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
