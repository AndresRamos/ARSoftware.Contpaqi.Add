using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata
{
    [Index("GuidDocument", Name = "IXFK_RetencionesXImp_Retenciones")]
    public partial class RetencionesXImp
    {
        public Guid GuidDocument { get; set; }
        [Key]
        [StringLength(60)]
        [Unicode(false)]
        public string IdImpuestoRet { get; set; } = null!;
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? BaseRet { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? Impuesto { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? ImpuestoDesc { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? montoRet { get; set; }
        [StringLength(60)]
        [Unicode(false)]
        public string? TipoPagoRet { get; set; }

        [ForeignKey("GuidDocument")]
        [InverseProperty("RetencionesXImp")]
        public virtual Retenciones GuidDocumentNavigation { get; set; } = null!;
    }
}
