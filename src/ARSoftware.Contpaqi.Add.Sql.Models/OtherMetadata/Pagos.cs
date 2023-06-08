using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata
{
    [Index("GuidDocument", Name = "IXFK_Pagos_CFDI")]
    public partial class Pagos
    {
        public Pagos()
        {
            Impuestos_Pagos = new HashSet<Impuestos_Pagos>();
            Pagos_Doc_Rel = new HashSet<Pagos_Doc_Rel>();
        }

        public Guid GuidDocument { get; set; }
        [Key]
        [StringLength(60)]
        [Unicode(false)]
        public string IdPago { get; set; } = null!;
        [StringLength(5)]
        [Unicode(false)]
        public string? Version { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaPago { get; set; }
        public int? FechaPagoMes { get; set; }
        public int? FechaPagoAnio { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? FormaDePagoP { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? FormaDePagoPDesc { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? MonedaP { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? MonedaPDesc { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TipoCambioP { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? Monto { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? NumOperacion { get; set; }
        [StringLength(15)]
        [Unicode(false)]
        public string? RfcEmisorCtaOrd { get; set; }
        [StringLength(300)]
        [Unicode(false)]
        public string? NomBancoOrdExt { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? CtaOrdenante { get; set; }
        [StringLength(15)]
        [Unicode(false)]
        public string? RfcEmisorCtaBen { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? CtaBeneficiario { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? TipoCadPago { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? TipoCadPagoDesc { get; set; }
        public string? CertPago { get; set; }
        public string? CadPago { get; set; }
        public string? SelloPago { get; set; }

        [ForeignKey("GuidDocument")]
        [InverseProperty("Pagos")]
        public virtual Comprobante GuidDocumentNavigation { get; set; } = null!;
        [InverseProperty("IdPagoNavigation")]
        public virtual ICollection<Impuestos_Pagos> Impuestos_Pagos { get; set; }
        [InverseProperty("IdPagoNavigation")]
        public virtual ICollection<Pagos_Doc_Rel> Pagos_Doc_Rel { get; set; }
    }
}
