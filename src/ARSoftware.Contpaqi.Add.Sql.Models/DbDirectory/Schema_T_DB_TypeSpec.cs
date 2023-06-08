using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    [Keyless]
    public partial class Schema_T_DB_TypeSpec
    {
        [StringLength(1)]
        [Unicode(false)]
        public string? IdSpec { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? DescSpec { get; set; }
    }
}
