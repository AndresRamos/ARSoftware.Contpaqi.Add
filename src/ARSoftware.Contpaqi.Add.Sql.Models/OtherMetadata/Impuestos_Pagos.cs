using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata
{
    [Index("GuidDocument", Name = "IXFK_Impuestos_Pagos_Pagos")]
    public partial class Impuestos_Pagos
    {
        public Guid GuidDocument { get; set; }
        [StringLength(60)]
        [Unicode(false)]
        public string IdPago { get; set; } = null!;
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TotalImpuestosRetenidos { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TotalImpuestosTrasladados { get; set; }
        [Key]
        [StringLength(60)]
        [Unicode(false)]
        public string IdImpuesto { get; set; } = null!;

        [ForeignKey("IdPago")]
        [InverseProperty("Impuestos_Pagos")]
        public virtual Pagos IdPagoNavigation { get; set; } = null!;
    }
}
