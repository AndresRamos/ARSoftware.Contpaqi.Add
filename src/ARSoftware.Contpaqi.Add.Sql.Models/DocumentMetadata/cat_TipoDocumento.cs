using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata;

public partial class cat_TipoDocumento
{
    public int IdTipoDocumento { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Documento> Documento { get; set; } = new List<Documento>();
}
