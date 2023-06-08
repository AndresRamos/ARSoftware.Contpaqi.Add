using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata
{
    [Index("GuidDocument", Name = "IXFK_Impuestos_Retenciones_Locales")]
    public partial class Impuestos_Retenciones_Locales
    {
        public Guid GuidDocument { get; set; }
        [Key]
        [StringLength(60)]
        [Unicode(false)]
        public string ImpDetalle { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string? ImpLocalRetenido { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TasadeRetencion { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? ImporteRetenido { get; set; }

        [ForeignKey("GuidDocument")]
        [InverseProperty("Impuestos_Retenciones_Locales")]
        public virtual Impuestos_Locales GuidDocumentNavigation { get; set; } = null!;
    }
}
