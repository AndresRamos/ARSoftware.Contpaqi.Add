using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata;

public partial class Comprobante
{
    public Guid GuidDocument { get; set; }

    public string? RFCEmisor { get; set; }

    public string? NombreEmisor { get; set; }

    public string? RegimenEmisor { get; set; }

    public string? RegimenEmisorDesc { get; set; }

    public string? CURPEmisor { get; set; }

    public string? RFCReceptor { get; set; }

    public string? NombreReceptor { get; set; }

    public string? RegimenReceptor { get; set; }

    public decimal? TotImpRetenidos { get; set; }

    public decimal? TotImpTraslado { get; set; }

    public string? Version { get; set; }

    public string? Serie { get; set; }

    public string? Folio { get; set; }

    public DateTime? Fecha { get; set; }

    public byte? FechaMes { get; set; }

    public short? FechaAnio { get; set; }

    public string? FormaPago { get; set; }

    public string? FormaPagoDesc { get; set; }

    public string? CondicionesPago { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? Descuento { get; set; }

    public decimal? TipoCambio { get; set; }

    public string? Moneda { get; set; }

    public string? MonedaDesc { get; set; }

    public decimal? Total { get; set; }

    public string? TipoComprobante { get; set; }

    public string? MetodoPago { get; set; }

    public string? MetodoPagoDesc { get; set; }

    public string? LugarExp { get; set; }

    public string? LugarExpDesc { get; set; }

    public Guid? UUID { get; set; }

    public DateTime? FechaTimbrado { get; set; }

    public int? FechaTimbradoMes { get; set; }

    public int? FechaTimbradoAnio { get; set; }

    public string? NumeroCertificado { get; set; }

    public string? Confirmacion { get; set; }

    public string? TipoDocumento { get; set; }

    public string? ResidenciaFiscal { get; set; }

    public string? ResidenciaFiscalDesc { get; set; }

    public string? NumRegIdTrib { get; set; }

    public string? UsoCFDI { get; set; }

    public string? UsoCFDI_Desc { get; set; }

    public string? TipoComprobanteDesc { get; set; }

    public string? NumCta { get; set; }

    public string? Exportacion { get; set; }

    public string? ExportacionDesc { get; set; }

    public string? DomicilioReceptor { get; set; }

    public string? RegimenReceptorDesc { get; set; }

    public string? NumeroOperacion { get; set; }

    public virtual ICollection<Conceptos> Conceptos { get; set; } = new List<Conceptos>();

    public virtual Documento GuidDocumentNavigation { get; set; } = null!;

    public virtual ImpuestosTotalizados? ImpuestosTotalizados { get; set; }

    public virtual Impuestos_Locales? Impuestos_Locales { get; set; }

    public virtual Nomina? Nomina { get; set; }

    public virtual ICollection<Pagos> Pagos { get; set; } = new List<Pagos>();
}
