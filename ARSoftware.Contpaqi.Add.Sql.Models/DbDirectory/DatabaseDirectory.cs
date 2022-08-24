using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    [Index("GuidCompany", "idDataBase", "DB_DocumentsMetadata", "DB_OthersMetadata", Name = "IXFKNC_DatabaseDirectory")]
    [Index("GuidCompany", "idDataBase", "DB_DocumentsContent", "DB_OthersContent", Name = "IXFKNC_DatabaseDirectory2")]
    public partial class DatabaseDirectory
    {
        public long idDataBase { get; set; }
        [Key]
        public Guid GuidCompany { get; set; }
        [StringLength(7)]
        [Unicode(false)]
        public string? Version { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? NombreEmpresa { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? DB_DocumentsMetadata { get; set; }
        [Column(TypeName = "decimal(12, 2)")]
        public decimal? Ver_DocumentsMetadata { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? DB_DocumentsContent { get; set; }
        [Column(TypeName = "decimal(12, 2)")]
        public decimal? Ver_DocumentsContent { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? DB_OthersMetadata { get; set; }
        [Column(TypeName = "decimal(12, 2)")]
        public decimal? Ver_OthersMetadata { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? DB_OthersContent { get; set; }
        [Column(TypeName = "decimal(12, 2)")]
        public decimal? Ver_OthersContent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Syncronized { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Accesibility { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeStamp { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Alias { get; set; }
        [StringLength(15)]
        [Unicode(false)]
        public string? RFC { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? CompanyPath { get; set; }
    }
}
