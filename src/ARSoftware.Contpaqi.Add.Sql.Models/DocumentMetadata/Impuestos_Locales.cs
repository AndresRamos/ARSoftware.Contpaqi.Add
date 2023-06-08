using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    [Index("GuidDocument", Name = "IXFK_Impuestos_Locales")]
    public partial class Impuestos_Locales
    {
        public Impuestos_Locales()
        {
            Impuestos_Retenciones_Locales = new HashSet<Impuestos_Retenciones_Locales>();
            Impuestos_Traslados_Locales = new HashSet<Impuestos_Traslados_Locales>();
        }

        [Key]
        public Guid GuidDocument { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Version { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TotalRetenciones { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TotalTraslados { get; set; }

        [ForeignKey("GuidDocument")]
        [InverseProperty("Impuestos_Locales")]
        public virtual Comprobante GuidDocumentNavigation { get; set; } = null!;
        [InverseProperty("GuidDocumentNavigation")]
        public virtual ICollection<Impuestos_Retenciones_Locales> Impuestos_Retenciones_Locales { get; set; }
        [InverseProperty("GuidDocumentNavigation")]
        public virtual ICollection<Impuestos_Traslados_Locales> Impuestos_Traslados_Locales { get; set; }
    }
}
