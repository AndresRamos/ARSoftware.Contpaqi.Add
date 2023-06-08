using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    [Index("GuidDocument", Name = "IXFK_Declaraciones_Documento")]
    public partial class Declaraciones
    {
        [Key]
        public Guid GuidDocument { get; set; }
        public int? Mes { get; set; }
        public int? Anio { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EmisionDateDeclaracion { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? OperationNum { get; set; }
        public Guid? PdfAcknowledgementGuid { get; set; }
        public Guid? XmlAcknowledgementGuid { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? PeriodDesc { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? FileName { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? ValidationStatus { get; set; }
        [StringLength(18)]
        [Unicode(false)]
        public string? RFC { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? TipoEnvio { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? TipoSolicitud { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? NumOrden { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? NumTramite { get; set; }

        [ForeignKey("GuidDocument")]
        [InverseProperty("Declaraciones")]
        public virtual Documento GuidDocumentNavigation { get; set; } = null!;
    }
}
