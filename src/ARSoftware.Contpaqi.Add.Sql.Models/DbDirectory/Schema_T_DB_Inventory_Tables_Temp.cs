using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory;

public partial class Schema_T_DB_Inventory_Tables_Temp
{
    public int IdDataBase { get; set; }

    public string? TableName { get; set; }

    public string? IdObject { get; set; }

    public int? NumberOfRows { get; set; }
}
