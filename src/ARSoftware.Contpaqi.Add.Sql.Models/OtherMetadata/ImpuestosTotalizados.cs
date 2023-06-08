using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata
{
    [Index("GuidDocument", Name = "IXFK_ImpuestosTotalizados")]
    public partial class ImpuestosTotalizados
    {
        [Key]
        public Guid GuidDocument { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ImporteTotalIVATraslado { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ImporteTotalISRRetenido { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ImporteTotalIEPSTraslado { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ImporteTotalIVARetenido { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? TotalImpuestosTrasladados { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? TotalImpuestosRetenidos { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ISRTrasladado { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? IEPSRetenido { get; set; }

        [ForeignKey("GuidDocument")]
        [InverseProperty("ImpuestosTotalizados")]
        public virtual Comprobante GuidDocumentNavigation { get; set; } = null!;
    }
}
