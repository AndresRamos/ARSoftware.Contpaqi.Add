using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata;

public partial class EstatusProceso
{
    public Guid GuidDocument { get; set; }

    public long? IdAccion { get; set; }

    public DateTime? Timestamp { get; set; }

    public string? Comentario { get; set; }

    public virtual Documento GuidDocumentNavigation { get; set; } = null!;
}
