using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata;

public partial class Partes
{
    public string IdConcepto { get; set; } = null!;

    public string IdParte { get; set; } = null!;

    public string? CveProdSer { get; set; }

    public string? CveProdSerDesc { get; set; }

    public string? NoIdentificacion { get; set; }

    public decimal? Cantidad { get; set; }

    public string? Unidad { get; set; }

    public string? Descripcion { get; set; }

    public decimal? ValorUnitario { get; set; }

    public decimal? Importe { get; set; }

    public virtual Conceptos IdConceptoNavigation { get; set; } = null!;
}
