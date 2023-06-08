using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    [Keyless]
    public partial class Schema_T_DB_Versions
    {
        public int IdDataBase { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? DataBaseName { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? Version { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string? ErrorDescription { get; set; }
    }
}
