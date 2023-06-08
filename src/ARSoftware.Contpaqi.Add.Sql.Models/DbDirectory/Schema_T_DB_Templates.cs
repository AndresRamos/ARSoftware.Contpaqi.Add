using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    [Keyless]
    public partial class Schema_T_DB_Templates
    {
        public int IdDataBase { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? DataBaseName { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? CurrentVersion { get; set; }
    }
}
