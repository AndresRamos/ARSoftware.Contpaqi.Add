using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata;

public partial class Impuesto_Retencion
{
    public Guid GuidDocument { get; set; }

    public string? Impuesto { get; set; }

    public string? ImpuestoDesc { get; set; }

    public decimal? Importe { get; set; }

    public virtual Comprobante GuidDocumentNavigation { get; set; } = null!;
}
