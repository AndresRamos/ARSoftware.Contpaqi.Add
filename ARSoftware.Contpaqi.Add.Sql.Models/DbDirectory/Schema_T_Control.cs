using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    [Keyless]
    public partial class Schema_T_Control
    {
        [StringLength(50)]
        [Unicode(false)]
        public string? IdObject { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? CurrentVersion { get; set; }
    }
}
