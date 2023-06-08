using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    [Keyless]
    [Index("GuidDocument", Name = "IXFK_Impuesto_Traslado_Comprobante")]
    public partial class Impuesto_Traslado
    {
        public Guid GuidDocument { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string? Impuesto { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? ImpuestoDesc { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? TipoFactor { get; set; }
        [StringLength(8)]
        [Unicode(false)]
        public string? TasaOCuota { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? Importe { get; set; }

        [ForeignKey("GuidDocument")]
        public virtual Comprobante GuidDocumentNavigation { get; set; } = null!;
    }
}
