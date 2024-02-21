using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory;

public partial class TempSysObj
{
    public int? Id { get; set; }

    public int? Parent_Object { get; set; }

    public string? Xtype { get; set; }
}
