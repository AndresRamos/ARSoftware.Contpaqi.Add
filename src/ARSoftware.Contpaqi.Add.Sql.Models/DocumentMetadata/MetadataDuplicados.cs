using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    [Keyless]
    public partial class MetadataDuplicados
    {
        public Guid? GuidDocument { get; set; }
        public Guid? GuidDocumentDuplicado { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? MetadataEstatusApp { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? UserResponsibleApp { get; set; }
        public string? ReferenceApp { get; set; }
        public string? NotesApp { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? ProcessApp { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartPeriodDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndPeriodDate { get; set; }
        public long? Period { get; set; }
        public int? Year { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TotalPayRoll { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? SalaryType { get; set; }
    }
}
