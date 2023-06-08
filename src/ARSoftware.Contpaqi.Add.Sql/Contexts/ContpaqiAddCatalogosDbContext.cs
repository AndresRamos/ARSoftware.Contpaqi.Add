using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ARSoftware.Contpaqi.Add.Sql.Models.Catalogos;

namespace ARSoftware.Contpaqi.Add.Sql.Contexts
{
    public partial class ContpaqiAddCatalogosDbContext : DbContext
    {
        public ContpaqiAddCatalogosDbContext()
        {
        }

        public ContpaqiAddCatalogosDbContext(DbContextOptions<ContpaqiAddCatalogosDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Control> Control { get; set; } = null!;
        public virtual DbSet<c_Aduanas> c_Aduanas { get; set; } = null!;
        public virtual DbSet<c_Banco> c_Banco { get; set; } = null!;
        public virtual DbSet<c_CFDIBancoR> c_CFDIBancoR { get; set; } = null!;
        public virtual DbSet<c_CatCodMoneda> c_CatCodMoneda { get; set; } = null!;
        public virtual DbSet<c_ClaveProdSTCC> c_ClaveProdSTCC { get; set; } = null!;
        public virtual DbSet<c_ClaveProdServ> c_ClaveProdServ { get; set; } = null!;
        public virtual DbSet<c_ClaveProdServCP> c_ClaveProdServCP { get; set; } = null!;
        public virtual DbSet<c_ClaveTipoCarga> c_ClaveTipoCarga { get; set; } = null!;
        public virtual DbSet<c_ClaveUnidad> c_ClaveUnidad { get; set; } = null!;
        public virtual DbSet<c_CodAgrup> c_CodAgrup { get; set; } = null!;
        public virtual DbSet<c_CodigoPostal> c_CodigoPostal { get; set; } = null!;
        public virtual DbSet<c_CodigoTransporteAereo> c_CodigoTransporteAereo { get; set; } = null!;
        public virtual DbSet<c_ConceptoPago> c_ConceptoPago { get; set; } = null!;
        public virtual DbSet<c_ConfigAutoTransporte> c_ConfigAutoTransporte { get; set; } = null!;
        public virtual DbSet<c_ConfigMaritima> c_ConfigMaritima { get; set; } = null!;
        public virtual DbSet<c_Contenedor> c_Contenedor { get; set; } = null!;
        public virtual DbSet<c_ContenedorMaritimo> c_ContenedorMaritimo { get; set; } = null!;
        public virtual DbSet<c_CveTipDivOUtil> c_CveTipDivOUtil { get; set; } = null!;
        public virtual DbSet<c_CveTransporte> c_CveTransporte { get; set; } = null!;
        public virtual DbSet<c_DerechosDePaso> c_DerechosDePaso { get; set; } = null!;
        public virtual DbSet<c_Estado> c_Estado { get; set; } = null!;
        public virtual DbSet<c_Exportacion> c_Exportacion { get; set; } = null!;
        public virtual DbSet<c_FormaPago> c_FormaPago { get; set; } = null!;
        public virtual DbSet<c_Impuesto> c_Impuesto { get; set; } = null!;
        public virtual DbSet<c_MaterialPeligroso> c_MaterialPeligroso { get; set; } = null!;
        public virtual DbSet<c_Meses> c_Meses { get; set; } = null!;
        public virtual DbSet<c_MetPag> c_MetPag { get; set; } = null!;
        public virtual DbSet<c_MetodoPago> c_MetodoPago { get; set; } = null!;
        public virtual DbSet<c_Moneda> c_Moneda { get; set; } = null!;
        public virtual DbSet<c_ObjetoImp> c_ObjetoImp { get; set; } = null!;
        public virtual DbSet<c_OrigenRecurso> c_OrigenRecurso { get; set; } = null!;
        public virtual DbSet<c_Pais> c_Pais { get; set; } = null!;
        public virtual DbSet<c_ParteTransporte> c_ParteTransporte { get; set; } = null!;
        public virtual DbSet<c_Periodicidad> c_Periodicidad { get; set; } = null!;
        public virtual DbSet<c_PeriodicidadPago> c_PeriodicidadPago { get; set; } = null!;
        public virtual DbSet<c_PeriodicidadRetenciones> c_PeriodicidadRetenciones { get; set; } = null!;
        public virtual DbSet<c_Regimen> c_Regimen { get; set; } = null!;
        public virtual DbSet<c_RegimenFiscal> c_RegimenFiscal { get; set; } = null!;
        public virtual DbSet<c_Retenciones> c_Retenciones { get; set; } = null!;
        public virtual DbSet<c_RetencionesImpuestos> c_RetencionesImpuestos { get; set; } = null!;
        public virtual DbSet<c_RiesgoPuesto> c_RiesgoPuesto { get; set; } = null!;
        public virtual DbSet<c_SubTipoRem> c_SubTipoRem { get; set; } = null!;
        public virtual DbSet<c_TipoAportODep> c_TipoAportODep { get; set; } = null!;
        public virtual DbSet<c_TipoCadena> c_TipoCadena { get; set; } = null!;
        public virtual DbSet<c_TipoCarro> c_TipoCarro { get; set; } = null!;
        public virtual DbSet<c_TipoContrato> c_TipoContrato { get; set; } = null!;
        public virtual DbSet<c_TipoDeComprobante> c_TipoDeComprobante { get; set; } = null!;
        public virtual DbSet<c_TipoDeServicio> c_TipoDeServicio { get; set; } = null!;
        public virtual DbSet<c_TipoDeTrafico> c_TipoDeTrafico { get; set; } = null!;
        public virtual DbSet<c_TipoDeduccion> c_TipoDeduccion { get; set; } = null!;
        public virtual DbSet<c_TipoEmbalaje> c_TipoEmbalaje { get; set; } = null!;
        public virtual DbSet<c_TipoHoras> c_TipoHoras { get; set; } = null!;
        public virtual DbSet<c_TipoIncapacidad> c_TipoIncapacidad { get; set; } = null!;
        public virtual DbSet<c_TipoJornada> c_TipoJornada { get; set; } = null!;
        public virtual DbSet<c_TipoNomina> c_TipoNomina { get; set; } = null!;
        public virtual DbSet<c_TipoOtroPago> c_TipoOtroPago { get; set; } = null!;
        public virtual DbSet<c_TipoPercepcion> c_TipoPercepcion { get; set; } = null!;
        public virtual DbSet<c_TipoPermiso> c_TipoPermiso { get; set; } = null!;
        public virtual DbSet<c_TipoRelacion> c_TipoRelacion { get; set; } = null!;
        public virtual DbSet<c_TipoRiesgo> c_TipoRiesgo { get; set; } = null!;
        public virtual DbSet<c_UnidadAduana> c_UnidadAduana { get; set; } = null!;
        public virtual DbSet<c_UsoCfdi> c_UsoCfdi { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Modern_Spanish_CI_AS");

            modelBuilder.Entity<Control>(entity =>
            {
                entity.HasIndex(e => new { e.IdCatalogo, e.Catalogo, e.Storage }, "IX_Control")
                    .IsClustered();

                entity.Property(e => e.IdCatalogo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_Aduanas>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_c_Aduanas")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_Banco>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_Banco")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_CFDIBancoR>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_c_CFDIBancoR")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_CatCodMoneda>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_c_CatCodMoneda")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_ClaveProdSTCC>(entity =>
            {
                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_ClaveProdServ>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_ClaveProdServ")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_ClaveProdServCP>(entity =>
            {
                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_ClaveTipoCarga>(entity =>
            {
                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_ClaveUnidad>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_ClaveUnidad")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_CodAgrup>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_c_CodAgrup")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_CodigoPostal>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_CodigoPostal")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_CodigoTransporteAereo>(entity =>
            {
                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_ConceptoPago>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_c_ConceptoPago")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_ConfigAutoTransporte>(entity =>
            {
                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_ConfigMaritima>(entity =>
            {
                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_Contenedor>(entity =>
            {
                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_ContenedorMaritimo>(entity =>
            {
                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_CveTipDivOUtil>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_c_CveTipDivOUtil")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_CveTransporte>(entity =>
            {
                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_DerechosDePaso>(entity =>
            {
                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_Estado>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_Estado")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_Exportacion>(entity =>
            {
                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_FormaPago>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_FormaPago")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_Impuesto>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_Impuesto")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_MaterialPeligroso>(entity =>
            {
                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_Meses>(entity =>
            {
                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_MetPag>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_c_MetPag")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_MetodoPago>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_MetodoPago")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_Moneda>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_Moneda")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_ObjetoImp>(entity =>
            {
                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_OrigenRecurso>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_OrigenRecurso")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_Pais>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_Pais")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_ParteTransporte>(entity =>
            {
                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_Periodicidad>(entity =>
            {
                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_PeriodicidadPago>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_PeriodicidadPago")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_PeriodicidadRetenciones>(entity =>
            {
                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_Regimen>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_Regimen")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_RegimenFiscal>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_RegimenFiscal")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_Retenciones>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_Retencion")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_RetencionesImpuestos>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_RetencionesImpuestos")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_RiesgoPuesto>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_RiesgoPuesto")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_SubTipoRem>(entity =>
            {
                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_TipoAportODep>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_CatPlanesDeRetiro")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_TipoCadena>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_TipoCadena")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_TipoCarro>(entity =>
            {
                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_TipoContrato>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_TipoContrato")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_TipoDeComprobante>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_TipoDeComprobante")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_TipoDeServicio>(entity =>
            {
                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_TipoDeTrafico>(entity =>
            {
                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_TipoDeduccion>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_TipoDeduccion")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_TipoEmbalaje>(entity =>
            {
                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_TipoHoras>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_TipoHoras")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_TipoIncapacidad>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_TipoIncapacidad")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_TipoJornada>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_TipoJornada")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_TipoNomina>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_TipoNomina")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_TipoOtroPago>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_TipoOtroPago")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_TipoPercepcion>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_TipoPercepcion")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_TipoPermiso>(entity =>
            {
                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_TipoRelacion>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_TipoRelacion")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_TipoRiesgo>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_TipoRiesgo")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_UnidadAduana>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_c_UnidadAduana")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<c_UsoCfdi>(entity =>
            {
                entity.HasIndex(e => e.Codigo, "IX_UsoCfdi")
                    .IsClustered();

                entity.Property(e => e.IdElemento).ValueGeneratedOnAdd();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
