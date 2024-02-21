using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata;

public partial class v_Expedientes
{
    public Guid? Guid_Exp { get; set; }

    public Guid? Guid_Rel { get; set; }

    public string? ApplicationType_Exp { get; set; }

    public string? Type_Exp { get; set; }

    public string? Comment_Exp { get; set; }

    public DateTime? TimeStamp_Exp { get; set; }
}
