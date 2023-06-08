using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata
{
    [Index("IdDetalle", Name = "IXFK_Nomina_HorasExtras")]
    public partial class Nomina_HorasExtras
    {
        public Guid GuidDocument { get; set; }
        [StringLength(60)]
        [Unicode(false)]
        public string? IdDetalle { get; set; }
        [Key]
        [StringLength(60)]
        [Unicode(false)]
        public string IdHoraExtra { get; set; } = null!;
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? Dias { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? TiposHoras { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? TiposHoras_Desc { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? HorasExtra { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? Importe { get; set; }

        [ForeignKey("GuidDocument")]
        [InverseProperty("Nomina_HorasExtras")]
        public virtual Nomina GuidDocumentNavigation { get; set; } = null!;
    }
}
