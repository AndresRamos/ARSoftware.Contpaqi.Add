using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
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

        public Guid GuidDocument { get; set; }
        public string? Version { get; set; }
        public string? TipoNomina { get; set; }
        public string? TipoNominaDesc { get; set; }
        public DateTime? FechaPago { get; set; }
        public byte? FechaPagoMes { get; set; }
        public short? FechaPagoAnio { get; set; }
        public DateTime? FechaInicialPago { get; set; }
        public DateTime? FechaFinalPago { get; set; }
        public decimal? NumDiasPagados { get; set; }
        public decimal? TotalPercepciones { get; set; }
        public decimal? TotalDeducciones { get; set; }
        public decimal? TotalOtrosPagos { get; set; }
        public string? RegistroPatronal { get; set; }
        public string? NumSeguridadSocialRec { get; set; }
        public DateTime? FechaInicioRelLaboral { get; set; }
        public string? Antiguedad { get; set; }
        public string? TipoContrato { get; set; }
        public string? TipoContratoDesc { get; set; }
        public string? Sindicalizado { get; set; }
        public string? TipoJornada { get; set; }
        public string? TipoJornadaDesc { get; set; }
        public string? TipoRegimen { get; set; }
        public string? TipoRegimenDesc { get; set; }
        public string? NumEmpleadoRec { get; set; }
        public string? DepartamentoRec { get; set; }
        public string? PuestoRec { get; set; }
        public string? RiesgoPuesto { get; set; }
        public string? RiesgoPuestoDesc { get; set; }
        public string? PeriodicidadPago { get; set; }
        public string? PeriodicidadPagoDesc { get; set; }
        public string? Banco { get; set; }
        public string? BancoDesc { get; set; }
        public decimal? SalarioBaseCotApor { get; set; }
        public decimal? SalarioDiarioIntegrado { get; set; }
        public string? ClaveEntFed { get; set; }
        public string? ClaveEntFedDesc { get; set; }
        public decimal? TotalSueldos { get; set; }
        public decimal? TotalSeparacionIndemnizacion { get; set; }
        public decimal? TotalGravadoPercepcion { get; set; }
        public decimal? TotalExentoPercepcion { get; set; }
        public decimal? TotalGravadoDeduccion { get; set; }
        public decimal? TotalExentoDeduccion { get; set; }
        public decimal? TotalPagado { get; set; }
        public byte? NumAnosServicio { get; set; }
        public decimal? UltimoSueldoMesOrd { get; set; }
        public decimal? IngresoAcumulable { get; set; }
        public decimal? IngresoNoAcumulable { get; set; }
        public decimal? TotalOtrasDeducciones { get; set; }
        public decimal? TotalImpuestosRetenidos { get; set; }
        public decimal? SaldoAFavor { get; set; }
        public int? Ano { get; set; }
        public decimal? RemanenteSalFav { get; set; }
        public decimal? SubsidioCausado { get; set; }
        public string? CuentaBancaria { get; set; }
        public string? CURPReceptor { get; set; }

        public virtual Comprobante GuidDocumentNavigation { get; set; } = null!;
        public virtual ICollection<EntidadSCNF> EntidadSCNF { get; set; }
        public virtual ICollection<Nomina_Detalle> Nomina_Detalle { get; set; }
        public virtual ICollection<Nomina_HorasExtras> Nomina_HorasExtras { get; set; }
        public virtual ICollection<Nomina_Incapacidad> Nomina_Incapacidad { get; set; }
        public virtual ICollection<Nomina_Subcontratacion> Nomina_Subcontratacion { get; set; }
    }
}
