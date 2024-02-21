using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory;

public partial class DocumentosDuplicados
{
    public Guid? GuidProcess { get; set; }

    public Guid? GuidDocumentDuplicado { get; set; }

    public Guid? UUID { get; set; }

    public Guid? GuidDocumentInDB { get; set; }

    public int? IDProcesso { get; set; }
}
