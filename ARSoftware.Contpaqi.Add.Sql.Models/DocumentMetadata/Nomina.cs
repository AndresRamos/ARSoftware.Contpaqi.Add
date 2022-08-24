using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    [Index("GuidDocument", Name = "IXFK_Nomina")]
    public partial class Nomina
    {
        public Nomina()
        {
            EntidadSCNF = new HashSet<EntidadSCNF>();
            Nomina_Detalle = new HashSet<Nomina_Detalle>();
            Nomina_HorasExtras = new HashSet<Nomina_HorasExtras>();
            Nomina_Incapacidad = new HashSet<Nomina_Incapacidad>();
            Nomina_Subcontratacion = new HashSet<Nomina_Subcontratacion>();
        }

        [Key]
        public Guid GuidDocument { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string? Version { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? TipoNomina { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? TipoNominaDesc { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaPago { get; set; }
        public byte? FechaPagoMes { get; set; }
        public short? FechaPagoAnio { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaInicialPago { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaFinalPago { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? NumDiasPagados { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TotalPercepciones { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TotalDeducciones { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TotalOtrosPagos { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? RegistroPatronal { get; set; }
        [StringLength(15)]
        [Unicode(false)]
        public string? NumSeguridadSocialRec { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaInicioRelLaboral { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? Antiguedad { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? TipoContrato { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? TipoContratoDesc { get; set; }
        [StringLength(2)]
        [Unicode(false)]
        public string? Sindicalizado { get; set; }
        [StringLength(25)]
        [Unicode(false)]
        public string? TipoJornada { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? TipoJornadaDesc { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? TipoRegimen { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? TipoRegimenDesc { get; set; }
        [StringLength(15)]
        [Unicode(false)]
        public string? NumEmpleadoRec { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? DepartamentoRec { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? PuestoRec { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? RiesgoPuesto { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? RiesgoPuestoDesc { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? PeriodicidadPago { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? PeriodicidadPagoDesc { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? Banco { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? BancoDesc { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? SalarioBaseCotApor { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? SalarioDiarioIntegrado { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? ClaveEntFed { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? ClaveEntFedDesc { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TotalSueldos { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TotalSeparacionIndemnizacion { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TotalGravadoPercepcion { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TotalExentoPercepcion { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TotalGravadoDeduccion { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TotalExentoDeduccion { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TotalPagado { get; set; }
        public byte? NumAnosServicio { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? UltimoSueldoMesOrd { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? IngresoAcumulable { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? IngresoNoAcumulable { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TotalOtrasDeducciones { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TotalImpuestosRetenidos { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? SaldoAFavor { get; set; }
        public int? Ano { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? RemanenteSalFav { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? SubsidioCausado { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string? CuentaBancaria { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? CURPReceptor { get; set; }

        [ForeignKey("GuidDocument")]
        [InverseProperty("Nomina")]
        public virtual Comprobante GuidDocumentNavigation { get; set; } = null!;
        [InverseProperty("GuidDocumentNavigation")]
        public virtual ICollection<EntidadSCNF> EntidadSCNF { get; set; }
        [InverseProperty("GuidDocumentNavigation")]
        public virtual ICollection<Nomina_Detalle> Nomina_Detalle { get; set; }
        [InverseProperty("GuidDocumentNavigation")]
        public virtual ICollection<Nomina_HorasExtras> Nomina_HorasExtras { get; set; }
        [InverseProperty("GuidDocumentNavigation")]
        public virtual ICollection<Nomina_Incapacidad> Nomina_Incapacidad { get; set; }
        [InverseProperty("GuidDocumentNavigation")]
        public virtual ICollection<Nomina_Subcontratacion> Nomina_Subcontratacion { get; set; }
    }
}
