using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata
{
    [Index("IdConcepto", Name = "IXFK_Partes_Conceptos")]
    public partial class Partes
    {
        [StringLength(60)]
        [Unicode(false)]
        public string IdConcepto { get; set; } = null!;
        [Key]
        [StringLength(60)]
        [Unicode(false)]
        public string IdParte { get; set; } = null!;
        [StringLength(25)]
        [Unicode(false)]
        public string? CveProdSer { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? CveProdSerDesc { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? NoIdentificacion { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? Cantidad { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Unidad { get; set; }
        [StringLength(1000)]
        [Unicode(false)]
        public string? Descripcion { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? ValorUnitario { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? Importe { get; set; }

        [ForeignKey("IdConcepto")]
        [InverseProperty("Partes")]
        public virtual Conceptos IdConceptoNavigation { get; set; } = null!;
    }
}
