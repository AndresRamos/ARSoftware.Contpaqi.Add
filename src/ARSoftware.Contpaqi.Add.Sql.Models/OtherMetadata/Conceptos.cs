using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata
{
    [Index("GuidDocument", Name = "IXFK_Conceptos_CFDI")]
    public partial class Conceptos
    {
        public Conceptos()
        {
            Partes = new HashSet<Partes>();
        }

        public Guid GuidDocument { get; set; }
        [Key]
        [StringLength(60)]
        [Unicode(false)]
        public string IdConcepto { get; set; } = null!;
        [StringLength(25)]
        [Unicode(false)]
        public string? CveProdSer { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? CveProdSerDesc { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? NoIdentificacion { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? Cantidad { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? ClaveUnidad { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? ClaveUnidadDesc { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Unidad { get; set; }
        [StringLength(1000)]
        [Unicode(false)]
        public string? Descripcion { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? ValorUnitario { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? Importe { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? Descuento { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? ObjetoImp { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? ObjetoImpDesc { get; set; }
        [StringLength(15)]
        [Unicode(false)]
        public string? RFCCtaTercero { get; set; }
        [StringLength(300)]
        [Unicode(false)]
        public string? NombreCtaTercero { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? RegimenFiscalCtaTercero { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? RegimenFiscalCtaTerceroDesc { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? DomicilioFiscalCtaTercero { get; set; }

        [ForeignKey("GuidDocument")]
        [InverseProperty("Conceptos")]
        public virtual Comprobante GuidDocumentNavigation { get; set; } = null!;
        [InverseProperty("IdConceptoNavigation")]
        public virtual ICollection<Partes> Partes { get; set; }
    }
}
