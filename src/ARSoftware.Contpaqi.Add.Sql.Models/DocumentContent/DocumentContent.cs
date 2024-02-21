using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentContent;

public partial class DocumentContent
{
    public Guid GuidDocument { get; set; }

    public string? DocumentType { get; set; }

    public string? FileName { get; set; }

    public string? Content { get; set; }

    public string? SubDirectory { get; set; }

    public DateTime? DocumentDate { get; set; }

    public DateTime? CreationDate { get; set; }
}
