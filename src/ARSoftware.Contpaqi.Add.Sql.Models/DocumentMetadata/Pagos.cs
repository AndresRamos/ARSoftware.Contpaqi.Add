using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata;

public partial class Pagos
{
    public Guid GuidDocument { get; set; }

    public string IdPago { get; set; } = null!;

    public string? Version { get; set; }

    public DateTime? FechaPago { get; set; }

    public int? FechaPagoMes { get; set; }

    public int? FechaPagoAnio { get; set; }

    public string? FormaDePagoP { get; set; }

    public string? FormaDePagoPDesc { get; set; }

    public string? MonedaP { get; set; }

    public string? MonedaPDesc { get; set; }

    public decimal? TipoCambioP { get; set; }

    public decimal? Monto { get; set; }

    public string? NumOperacion { get; set; }

    public string? RfcEmisorCtaOrd { get; set; }

    public string? NomBancoOrdExt { get; set; }

    public string? CtaOrdenante { get; set; }

    public string? RfcEmisorCtaBen { get; set; }

    public string? CtaBeneficiario { get; set; }

    public string? TipoCadPago { get; set; }

    public string? TipoCadPagoDesc { get; set; }

    public string? CertPago { get; set; }

    public string? CadPago { get; set; }

    public string? SelloPago { get; set; }

    public virtual Comprobante GuidDocumentNavigation { get; set; } = null!;

    public virtual ICollection<Impuestos_Pagos> Impuestos_Pagos { get; set; } = new List<Impuestos_Pagos>();

    public virtual ICollection<Pagos_Doc_Rel> Pagos_Doc_Rel { get; set; } = new List<Pagos_Doc_Rel>();
}
