using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata;

public partial class Pagos_Doc_Rel
{
    public Guid GuidDocument { get; set; }

    public string IdPago { get; set; } = null!;

    public string IdDocumento { get; set; } = null!;

    public string? Serie { get; set; }

    public string? Folio { get; set; }

    public string? MonedaDR { get; set; }

    public string? MonedaDRDesc { get; set; }

    public decimal? TipoCambioDR { get; set; }

    public string? MetodoDePagoDR { get; set; }

    public string? MetodoDePagoDRDesc { get; set; }

    public int? NumParcialidad { get; set; }

    public decimal? ImpSaldoAnt { get; set; }

    public decimal? ImpPagado { get; set; }

    public decimal? ImpSaldoInsoluto { get; set; }

    public string? ObjetoImpDR { get; set; }

    public string? ObjetoImpDRDesc { get; set; }

    public decimal? EquivalenciaDR { get; set; }

    public Guid IdDoctoUnique { get; set; }

    public virtual Pagos IdPagoNavigation { get; set; } = null!;
}
