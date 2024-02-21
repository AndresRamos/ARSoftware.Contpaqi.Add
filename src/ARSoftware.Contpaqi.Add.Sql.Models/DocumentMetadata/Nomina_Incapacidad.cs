using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata;

public partial class Nomina_Incapacidad
{
    public Guid GuidDocument { get; set; }

    public string IdIncapacidad { get; set; } = null!;

    public decimal? Dias { get; set; }

    public string? TipoIncapacidad { get; set; }

    public string? TipoIncapacidad_Desc { get; set; }

    public decimal? Importe { get; set; }

    public virtual Nomina GuidDocumentNavigation { get; set; } = null!;
}
