using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory;

public partial class Schema_T_DB_Inventory_Table_Detail
{
    public int IdDataBase { get; set; }

    public string? TableName { get; set; }

    public string? ColumnName { get; set; }

    public int? XtypeCode { get; set; }

    public string? Xtype { get; set; }

    public int? Lenght { get; set; }

    public int? Prec { get; set; }

    public int? Scale { get; set; }

    public int? ColOrder { get; set; }
}
