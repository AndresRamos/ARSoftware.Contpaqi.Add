using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    [Index("GuidDocument", "UUID", Name = "IXFKNC_Retenciones_Documento")]
    public partial class Retenciones
    {
        public Retenciones()
        {
            RetencionesXImp = new HashSet<RetencionesXImp>();
        }

        [Key]
        public Guid GuidDocument { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Nacionalidad { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? NumRegIdTrib { get; set; }
        public int? MesIni { get; set; }
        public int? MesFin { get; set; }
        public int? Ejerc { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? MontoTotOperacion { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? MontoTotGrav { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? MontoTotExent { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? MontoTotRet { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Version { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Folio { get; set; }
        public string? Sello { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? NumCert { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaExp { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? CveRetenc { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? DescRetenc { get; set; }
        [StringLength(15)]
        [Unicode(false)]
        public string? RFCEmisor { get; set; }
        [StringLength(300)]
        [Unicode(false)]
        public string? NomDenRazSocE { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? CURPE { get; set; }
        [StringLength(15)]
        [Unicode(false)]
        public string? RFCRecep { get; set; }
        [StringLength(300)]
        [Unicode(false)]
        public string? NomDenRazSocR { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? CURPR { get; set; }
        [StringLength(300)]
        [Unicode(false)]
        public string? NomDenRazSocRExt { get; set; }
        public Guid? UUID { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? LugarExp { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? LugarExpDesc { get; set; }
        public Guid? UUIDRelacionado { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? TipoRelacion { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? TipoRelacionDesc { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? RegimenEmisor { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? RegimenEmisorDesc { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? DomicilioReceptor { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? UtilidadBimestral { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? ISRCorrespondiente { get; set; }

        [ForeignKey("GuidDocument")]
        [InverseProperty("Retenciones")]
        public virtual Documento GuidDocumentNavigation { get; set; } = null!;
        [InverseProperty("GuidDocumentNavigation")]
        public virtual ICollection<RetencionesXImp> RetencionesXImp { get; set; }
    }
}
