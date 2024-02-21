using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata;

public partial class TotalPagos
{
    public Guid GuidDocument { get; set; }

    public decimal? TotalRetencionesIVA { get; set; }

    public decimal? TotalRetencionesISR { get; set; }

    public decimal? TotalRetencionesIEPS { get; set; }

    public decimal? TotalTrasladoBaseIVA16 { get; set; }

    public decimal? TotalTrasladoImpuestoIVA16 { get; set; }

    public decimal? TotalTrasladoBaseIVA8 { get; set; }

    public decimal? TotalTrasladoImpuestoIVA8 { get; set; }

    public decimal? TotalTrasladoBaseIVA0 { get; set; }

    public decimal? TotalTrasladoImpuestoIVA0 { get; set; }

    public decimal? TotalTrasladoBaseIVAExento { get; set; }

    public decimal? MontoTotalPagos { get; set; }

    public virtual Comprobante GuidDocumentNavigation { get; set; } = null!;
}
