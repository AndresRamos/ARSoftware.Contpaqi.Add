using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    [Keyless]
    public partial class TempSysObj
    {
        public int? Id { get; set; }
        public int? Parent_Object { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? Xtype { get; set; }
    }
}
