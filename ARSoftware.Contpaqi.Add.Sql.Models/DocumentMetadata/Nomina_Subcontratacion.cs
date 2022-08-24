using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    [Index("GuidDocument", "IdSub", Name = "IXFKNC_Nomina_ISubcontratacion")]
    public partial class Nomina_Subcontratacion
    {
        public Guid GuidDocument { get; set; }
        [Key]
        [StringLength(60)]
        [Unicode(false)]
        public string IdSub { get; set; } = null!;
        [StringLength(13)]
        [Unicode(false)]
        public string? RFCLabora { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? PorcTiempo { get; set; }

        [ForeignKey("GuidDocument")]
        [InverseProperty("Nomina_Subcontratacion")]
        public virtual Nomina GuidDocumentNavigation { get; set; } = null!;
    }
}
