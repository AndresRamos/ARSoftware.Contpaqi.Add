using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory;

public partial class Schema_T_DB_Templates
{
    public int IdDataBase { get; set; }

    public string? DataBaseName { get; set; }

    public string? CurrentVersion { get; set; }
}
