using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    [Index("GuidDocument", "IdIncapacidad", Name = "IXFKNC_Nomina_Incapacidad")]
    public partial class Nomina_Incapacidad
    {
        public Guid GuidDocument { get; set; }
        [Key]
        [StringLength(60)]
        [Unicode(false)]
        public string IdIncapacidad { get; set; } = null!;
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? Dias { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? TipoIncapacidad { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? TipoIncapacidad_Desc { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? Importe { get; set; }

        [ForeignKey("GuidDocument")]
        [InverseProperty("Nomina_Incapacidad")]
        public virtual Nomina GuidDocumentNavigation { get; set; } = null!;
    }
}
