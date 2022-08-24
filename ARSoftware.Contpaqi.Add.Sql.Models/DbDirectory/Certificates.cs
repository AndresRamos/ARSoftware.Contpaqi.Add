using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    [Keyless]
    [Index("GuidDocument", Name = "IXFK_Certificates")]
    public partial class Certificates
    {
        public Guid GuidDocument { get; set; }
        [Column(TypeName = "text")]
        public string? LlavePublica { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string? NumeroSerie { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaInicial { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaFinal { get; set; }
        [Column(TypeName = "text")]
        public string? SubjectName { get; set; }
        [Column(TypeName = "text")]
        public string? IssuerName { get; set; }
        public bool? IsTesting { get; set; }
    }
}
