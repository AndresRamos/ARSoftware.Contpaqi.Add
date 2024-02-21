using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory;

public partial class MergeDocs
{
    public Guid? GuidProcess_Merge { get; set; }

    public Guid? GuidCompanySource { get; set; }

    public Guid? GuidCompanyDestination { get; set; }

    public Guid? GuidDocument { get; set; }

    public string? Storage { get; set; }

    public string? DocType { get; set; }

    public byte? Operation { get; set; }

    public Guid? UUID { get; set; }

    public Guid? GuidDocumentDest { get; set; }
}
