using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    [Index("GuidDocument", Name = "IXFK_Impuestos_Traslados_Locales")]
    public partial class Impuestos_Traslados_Locales
    {
        public Guid GuidDocument { get; set; }
        [Key]
        [StringLength(60)]
        [Unicode(false)]
        public string ImpDetalle { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string? ImpLocalTrasladado { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TasadeTraslado { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? ImporteTraslado { get; set; }

        [ForeignKey("GuidDocument")]
        [InverseProperty("Impuestos_Traslados_Locales")]
        public virtual Impuestos_Locales GuidDocumentNavigation { get; set; } = null!;
    }
}
