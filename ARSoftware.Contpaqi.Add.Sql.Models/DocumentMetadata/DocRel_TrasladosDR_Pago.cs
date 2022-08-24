using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    [Keyless]
    [Index("IdPago", Name = "IXFK_TrasladosDR_Pago")]
    [Index("IdDoctoUnique", Name = "IXFK_TrasladosDR_Pago_IdDoctoUnique")]
    public partial class DocRel_TrasladosDR_Pago
    {
        [StringLength(60)]
        [Unicode(false)]
        public string IdPago { get; set; } = null!;
        public Guid IdDoctoUnique { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? BaseDR { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? ImpuestoDR { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? ImpuestoDRDesc { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? TipoFactorDR { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TasaOCuotaDR { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? ImporteDR { get; set; }

        [ForeignKey("IdPago,IdDoctoUnique")]
        public virtual Pagos_Doc_Rel Id { get; set; } = null!;
    }
}
