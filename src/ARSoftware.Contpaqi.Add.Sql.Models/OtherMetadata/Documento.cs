using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata
{
    [Index("GuidDocument", "IdTipoDocumento", "Type", Name = "IXFK_Documento")]
    [Index("GuidDocument", Name = "IXNC_SourceFile")]
    public partial class Documento
    {
        [Key]
        public Guid GuidDocument { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Path { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Hash { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Status { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? MetadataEstatusApp { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? UserResponsibleApp { get; set; }
        public string? ReferenceApp { get; set; }
        public string? NotesApp { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeStamp { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? ProcessApp { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? NoPaymentStatusapp { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string? ClaveDescripcion { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? SourceFile { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? Type_Otro { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? Type_Ext { get; set; }
        public int? IdTipoDocumento { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartPeriodDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndPeriodDate { get; set; }
        public long? Period { get; set; }
        public int? Year { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? TotalPayRoll { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? SalaryType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EmisionDate { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? Type { get; set; }
        public byte? IsAsoContabilidad { get; set; }
        public byte? IsAsoComercial { get; set; }
        public byte? IsAsoBancos { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? ValidationStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CancelDate { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? CancelStatus { get; set; }

        [ForeignKey("IdTipoDocumento")]
        [InverseProperty("Documento")]
        public virtual cat_TipoDocumento? IdTipoDocumentoNavigation { get; set; }
        [InverseProperty("GuidDocumentNavigation")]
        public virtual Comprobante Comprobante { get; set; } = null!;
        [InverseProperty("GuidDocumentNavigation")]
        public virtual Declaraciones Declaraciones { get; set; } = null!;
        [InverseProperty("GuidDocumentNavigation")]
        public virtual Doc_App Doc_App { get; set; } = null!;
        [InverseProperty("GuidDocumentNavigation")]
        public virtual Retenciones Retenciones { get; set; } = null!;
    }
}
