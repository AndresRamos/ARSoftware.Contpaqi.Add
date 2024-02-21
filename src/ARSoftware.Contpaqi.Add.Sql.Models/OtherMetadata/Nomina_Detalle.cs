using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata;

public partial class Nomina_Detalle
{
    public Guid GuidDocument { get; set; }

    public string? TipoNominaDetalle { get; set; }

    public string IdDetalle { get; set; } = null!;

    public string? TipoDetalle { get; set; }

    public string? TipoDetalleDesc { get; set; }

    public string? Clave { get; set; }

    public string? Concepto { get; set; }

    public decimal? ImporteGravado { get; set; }

    public decimal? ImporteExento { get; set; }

    public decimal? Importe { get; set; }

    public virtual Nomina GuidDocumentNavigation { get; set; } = null!;
}
