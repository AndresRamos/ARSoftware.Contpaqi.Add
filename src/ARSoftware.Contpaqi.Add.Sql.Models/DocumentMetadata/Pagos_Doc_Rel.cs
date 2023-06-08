using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    [Index("GuidDocument", Name = "IXFK_Pagos_Doc_Rel_Pagos")]
    [Index("IdDoctoUnique", Name = "IXFK_Pagos_Doc_Rel_Pagos_IdDoctoUnique")]
    [Index("IdPago", Name = "IXFK_Pagos_Doc_Rel_Pagos_IdPago")]
    public partial class Pagos_Doc_Rel
    {
        public Guid GuidDocument { get; set; }
        [Key]
        [StringLength(60)]
        [Unicode(false)]
        public string IdPago { get; set; } = null!;
        [StringLength(36)]
        [Unicode(false)]
        public string IdDocumento { get; set; } = null!;
        [StringLength(25)]
        [Unicode(false)]
        public string? Serie { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string? Folio { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? MonedaDR { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? MonedaDRDesc { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TipoCambioDR { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? MetodoDePagoDR { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? MetodoDePagoDRDesc { get; set; }
        public int? NumParcialidad { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? ImpSaldoAnt { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? ImpPagado { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? ImpSaldoInsoluto { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? ObjetoImpDR { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? ObjetoImpDRDesc { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? EquivalenciaDR { get; set; }
        [Key]
        public Guid IdDoctoUnique { get; set; }

        [ForeignKey("IdPago")]
        [InverseProperty("Pagos_Doc_Rel")]
        public virtual Pagos IdPagoNavigation { get; set; } = null!;
    }
}
