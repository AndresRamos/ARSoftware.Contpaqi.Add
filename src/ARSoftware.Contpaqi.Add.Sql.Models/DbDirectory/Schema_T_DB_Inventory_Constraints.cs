using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    public partial class Schema_T_DB_Inventory_Constraints
    {
        public int IdDataBase { get; set; }
        public string? ConstraintName { get; set; }
        public string? IdObject { get; set; }
    }
}
