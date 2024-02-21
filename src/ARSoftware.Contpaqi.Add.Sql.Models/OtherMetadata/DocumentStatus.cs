using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata;

public partial class DocumentStatus
{
    public Guid GuidDocument { get; set; }

    public string? IdError { get; set; }

    public string? ErrorDescription { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? LlastmodifiedDate { get; set; }

    public int? Status { get; set; }
}
