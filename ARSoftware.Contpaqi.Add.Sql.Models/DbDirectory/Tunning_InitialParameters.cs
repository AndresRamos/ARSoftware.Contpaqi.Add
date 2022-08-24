using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    [Keyless]
    public partial class Tunning_InitialParameters
    {
        [StringLength(50)]
        [Unicode(false)]
        public string? DBTemplate { get; set; }
        public int? LogSize { get; set; }
        [Column(TypeName = "decimal(12, 2)")]
        public decimal? LogLevel1 { get; set; }
        [Column(TypeName = "decimal(12, 2)")]
        public decimal? LogLevel2 { get; set; }
        [Column(TypeName = "decimal(12, 2)")]
        public decimal? LogLevel3 { get; set; }
        [Column(TypeName = "decimal(12, 2)")]
        public decimal? IdxLevel1 { get; set; }
        [Column(TypeName = "decimal(12, 2)")]
        public decimal? IdxLevel2 { get; set; }
        [Column(TypeName = "decimal(12, 2)")]
        public decimal? IdxLevel3 { get; set; }
    }
}
