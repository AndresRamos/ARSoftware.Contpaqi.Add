using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata;

public partial class Nomina_HorasExtras
{
    public Guid GuidDocument { get; set; }

    public string? IdDetalle { get; set; }

    public string IdHoraExtra { get; set; } = null!;

    public decimal? Dias { get; set; }

    public string? TiposHoras { get; set; }

    public string? TiposHoras_Desc { get; set; }

    public decimal? HorasExtra { get; set; }

    public decimal? Importe { get; set; }

    public virtual Nomina GuidDocumentNavigation { get; set; } = null!;
}
