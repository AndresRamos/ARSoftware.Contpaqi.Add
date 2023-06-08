using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    [Keyless]
    public partial class Schema_CompaniesProgObj_Temp
    {
        public int? IdObj { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? NameObj { get; set; }
        [StringLength(2)]
        [Unicode(false)]
        public string? XType { get; set; }
        [StringLength(25)]
        [Unicode(false)]
        public string? Ver { get; set; }
        public int? Template { get; set; }
    }
}
