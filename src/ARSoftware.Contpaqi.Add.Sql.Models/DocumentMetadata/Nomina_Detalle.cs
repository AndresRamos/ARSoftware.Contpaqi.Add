using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    [Index("GuidDocument", Name = "IXFK_Nomina_Detalle_Nomina")]
    public partial class Nomina_Detalle
    {
        public Guid GuidDocument { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string? TipoNominaDetalle { get; set; }
        [Key]
        [StringLength(60)]
        [Unicode(false)]
        public string IdDetalle { get; set; } = null!;
        [StringLength(10)]
        [Unicode(false)]
        public string? TipoDetalle { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? TipoDetalleDesc { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string? Clave { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string? Concepto { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? ImporteGravado { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? ImporteExento { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? Importe { get; set; }

        [ForeignKey("GuidDocument")]
        [InverseProperty("Nomina_Detalle")]
        public virtual Nomina GuidDocumentNavigation { get; set; } = null!;
    }
}
