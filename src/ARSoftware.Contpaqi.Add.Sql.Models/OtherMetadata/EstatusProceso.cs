using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata
{
    [Keyless]
    [Index("GuidDocument", Name = "IXFK_EstatusProceso_Documento")]
    public partial class EstatusProceso
    {
        public Guid GuidDocument { get; set; }
        public long? IdAccion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Timestamp { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Comentario { get; set; }

        [ForeignKey("GuidDocument")]
        public virtual Documento GuidDocumentNavigation { get; set; } = null!;
    }
}
