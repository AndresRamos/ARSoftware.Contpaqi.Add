using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory;

public partial class Schema_T_DB_Inventory_Functions
{
    public int IdDataBase { get; set; }

    public string? FunctionName { get; set; }

    public int? CodeSize { get; set; }

    public string? IdObject { get; set; }
}
