using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata;

public partial class Nomina_Subcontratacion
{
    public Guid GuidDocument { get; set; }

    public string IdSub { get; set; } = null!;

    public string? RFCLabora { get; set; }

    public decimal? PorcTiempo { get; set; }

    public virtual Nomina GuidDocumentNavigation { get; set; } = null!;
}
