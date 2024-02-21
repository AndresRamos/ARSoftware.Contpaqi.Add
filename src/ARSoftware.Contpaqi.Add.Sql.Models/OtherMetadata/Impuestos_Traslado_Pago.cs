using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata;

public partial class Impuestos_Traslado_Pago
{
    public string IdImpuesto { get; set; } = null!;

    public Guid GuidDocument { get; set; }

    public string? Impuesto { get; set; }

    public string? ImpuestoDesc { get; set; }

    public string? TipoFactor { get; set; }

    public string? TasaOCuota { get; set; }

    public decimal? Importe { get; set; }

    public virtual Impuestos_Pagos IdImpuestoNavigation { get; set; } = null!;
}
