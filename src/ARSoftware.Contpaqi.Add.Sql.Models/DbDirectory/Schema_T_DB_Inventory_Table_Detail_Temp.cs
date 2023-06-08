using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    [Keyless]
    public partial class Schema_T_DB_Inventory_Table_Detail_Temp
    {
        public int IdDataBase { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? TableName { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? ColumnName { get; set; }
        public int? XtypeCode { get; set; }
        [StringLength(25)]
        [Unicode(false)]
        public string? Xtype { get; set; }
        public int? Lenght { get; set; }
        public int? Prec { get; set; }
        public int? Scale { get; set; }
        public int? ColOrder { get; set; }
    }
}
