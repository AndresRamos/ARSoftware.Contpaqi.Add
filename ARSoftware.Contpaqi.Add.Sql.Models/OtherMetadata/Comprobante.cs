using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata
{
    [Index("GuidDocument", "Fecha", "UUID", "Version", Name = "IXFKNC_CFDI_Documento")]
    [Index("RFCEmisor", Name = "IXNC_EDOSRFCEM")]
    [Index("RFCReceptor", Name = "IXNC_EDOSRFCRE")]
    [Index("UUID", Name = "IXNC_UUID")]
    [Index("RFCEmisor", "Fecha", Name = "NCTA_Comprobante_1")]
    public partial class Comprobante
    {
        public Comprobante()
        {
            Conceptos = new HashSet<Conceptos>();
            Pagos = new HashSet<Pagos>();
        }

        [Key]
        public Guid GuidDocument { get; set; }
        [StringLength(13)]
        [Unicode(false)]
        public string? RFCEmisor { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? NombreEmisor { get; set; }
        [StringLength(254)]
        [Unicode(false)]
        public string? RegimenEmisor { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? RegimenEmisorDesc { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? CURPEmisor { get; set; }
        [StringLength(13)]
        [Unicode(false)]
        public string? RFCReceptor { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? NombreReceptor { get; set; }
        [StringLength(254)]
        [Unicode(false)]
        public string? RegimenReceptor { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TotImpRetenidos { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TotImpTraslado { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string? Version { get; set; }
        [StringLength(25)]
        [Unicode(false)]
        public string? Serie { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string? Folio { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        public byte? FechaMes { get; set; }
        public short? FechaAnio { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? FormaPago { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? FormaPagoDesc { get; set; }
        [StringLength(1000)]
        [Unicode(false)]
        public string? CondicionesPago { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? Subtotal { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? Descuento { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TipoCambio { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Moneda { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? MonedaDesc { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? Total { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? TipoComprobante { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? MetodoPago { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? MetodoPagoDesc { get; set; }
        [Unicode(false)]
        public string? LugarExp { get; set; }
        [Unicode(false)]
        public string? LugarExpDesc { get; set; }
        public Guid? UUID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaTimbrado { get; set; }
        public int? FechaTimbradoMes { get; set; }
        public int? FechaTimbradoAnio { get; set; }
        [StringLength(60)]
        [Unicode(false)]
        public string? NumeroCertificado { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Confirmacion { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? TipoDocumento { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? ResidenciaFiscal { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? ResidenciaFiscalDesc { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string? NumRegIdTrib { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? UsoCFDI { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? UsoCFDI_Desc { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? TipoComprobanteDesc { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string? NumCta { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? Exportacion { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? ExportacionDesc { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? DomicilioReceptor { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? RegimenReceptorDesc { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? NumeroOperacion { get; set; }

        [ForeignKey("GuidDocument")]
        [InverseProperty("Comprobante")]
        public virtual Documento GuidDocumentNavigation { get; set; } = null!;
        [InverseProperty("GuidDocumentNavigation")]
        public virtual ImpuestosTotalizados ImpuestosTotalizados { get; set; } = null!;
        [InverseProperty("GuidDocumentNavigation")]
        public virtual Impuestos_Locales Impuestos_Locales { get; set; } = null!;
        [InverseProperty("GuidDocumentNavigation")]
        public virtual Nomina Nomina { get; set; } = null!;
        [InverseProperty("GuidDocumentNavigation")]
        public virtual ICollection<Conceptos> Conceptos { get; set; }
        [InverseProperty("GuidDocumentNavigation")]
        public virtual ICollection<Pagos> Pagos { get; set; }
    }
}
