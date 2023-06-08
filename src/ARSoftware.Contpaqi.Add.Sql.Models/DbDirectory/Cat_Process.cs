using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    [Index("ID_Process", Name = "IXFK_Cat_Process")]
    public partial class Cat_Process
    {
        [Key]
        public int ID_Process { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? DescripcionProcces { get; set; }
    }
}
