using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata;

public partial class Impuestos_Traslados_Locales
{
    public Guid GuidDocument { get; set; }

    public string ImpDetalle { get; set; } = null!;

    public string? ImpLocalTrasladado { get; set; }

    public decimal? TasadeTraslado { get; set; }

    public decimal? ImporteTraslado { get; set; }

    public virtual Impuestos_Locales GuidDocumentNavigation { get; set; } = null!;
}
