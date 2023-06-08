using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata
{
    [Index("GuidDocument", Name = "IXFK_Certificates")]
    public partial class Certificates
    {
        [Key]
        public Guid GuidDocument { get; set; }
        public string? LlavePublica { get; set; }
        public string? LlavePrivada { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string? NumeroSerie { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaInicial { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaFinal { get; set; }
        public string? SubjectName { get; set; }
        public string? IssuerName { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? ActualCSDStatus { get; set; }
        public bool? IsTesting { get; set; }
    }
}
