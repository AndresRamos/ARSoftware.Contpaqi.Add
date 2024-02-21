using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata;

public partial class Impuestos_Pagos
{
    public Guid GuidDocument { get; set; }

    public string IdPago { get; set; } = null!;

    public decimal? TotalImpuestosRetenidos { get; set; }

    public decimal? TotalImpuestosTrasladados { get; set; }

    public string IdImpuesto { get; set; } = null!;

    public virtual Pagos IdPagoNavigation { get; set; } = null!;
}
