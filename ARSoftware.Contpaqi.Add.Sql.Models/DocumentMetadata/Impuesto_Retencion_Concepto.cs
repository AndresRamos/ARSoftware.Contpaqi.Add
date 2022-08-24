using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    [Keyless]
    [Index("IdConcepto", Name = "IXFK_Impuesto_Retencion_Concepto_Conceptos")]
    public partial class Impuesto_Retencion_Concepto
    {
        [StringLength(60)]
        [Unicode(false)]
        public string IdConcepto { get; set; } = null!;
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? Base { get; set; }
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

        [ForeignKey("IdConcepto")]
        public virtual Conceptos IdConceptoNavigation { get; set; } = null!;
    }
}
