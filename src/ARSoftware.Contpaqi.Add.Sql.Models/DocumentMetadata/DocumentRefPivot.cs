using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata;

public partial class DocumentRefPivot
{
    public int Id { get; set; }

    public Guid GuidDocument { get; set; }

    public Guid? Guid { get; set; }

    public string? AggregationType { get; set; }

    public string? ApplicationType { get; set; }

    public string? Comment { get; set; }
}
