using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    [Keyless]
    [Index("GuidDocument", Name = "IXFK_Total_Pagos")]
    public partial class TotalPagos
    {
        public Guid GuidDocument { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TotalRetencionesIVA { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TotalRetencionesISR { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TotalRetencionesIEPS { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TotalTrasladoBaseIVA16 { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TotalTrasladoImpuestoIVA16 { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TotalTrasladoBaseIVA8 { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TotalTrasladoImpuestoIVA8 { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TotalTrasladoBaseIVA0 { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TotalTrasladoImpuestoIVA0 { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TotalTrasladoBaseIVAExento { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? MontoTotalPagos { get; set; }

        [ForeignKey("GuidDocument")]
        public virtual Comprobante GuidDocumentNavigation { get; set; } = null!;
    }
}
