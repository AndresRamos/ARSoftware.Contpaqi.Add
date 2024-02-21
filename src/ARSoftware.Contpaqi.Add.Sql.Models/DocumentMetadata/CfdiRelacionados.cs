using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata;

public partial class CfdiRelacionados
{
    public Guid GuidDocument { get; set; }

    public Guid UUID { get; set; }

    public string? TipoRelacion { get; set; }

    public string? TipoRelacionDesc { get; set; }

    public virtual Comprobante GuidDocumentNavigation { get; set; } = null!;
}
