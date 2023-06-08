using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata
{
    [Keyless]
    [Index("GuidDocument", Name = "IXFK_Impuesto_Retencion_Pago_Pagos")]
    public partial class Impuestos_Retencion_Pago
    {
        [StringLength(60)]
        [Unicode(false)]
        public string IdImpuesto { get; set; } = null!;
        public Guid GuidDocument { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string? Impuesto { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? ImpuestoDesc { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? Importe { get; set; }

        [ForeignKey("IdImpuesto")]
        public virtual Impuestos_Pagos IdImpuestoNavigation { get; set; } = null!;
    }
}
