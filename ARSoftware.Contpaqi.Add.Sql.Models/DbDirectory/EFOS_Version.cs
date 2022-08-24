using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    [Keyless]
    public partial class EFOS_Version
    {
        public int Type { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? Version { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string? URL { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
    }
}
