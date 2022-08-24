using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata
{
    [Index("GuidDocument", "IdEntidadSCNF", Name = "IXFKNC_EntidadSCNF_Nomina")]
    public partial class EntidadSCNF
    {
        public Guid GuidDocument { get; set; }
        [Key]
        [StringLength(60)]
        [Unicode(false)]
        public string IdEntidadSCNF { get; set; } = null!;
        [StringLength(10)]
        [Unicode(false)]
        public string? OrigenRecurso { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? OrigenRecursoDesc { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? MontoRecursoPropio { get; set; }

        [ForeignKey("GuidDocument")]
        [InverseProperty("EntidadSCNF")]
        public virtual Nomina GuidDocumentNavigation { get; set; } = null!;
    }
}
