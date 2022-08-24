using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata
{
    [Keyless]
    [Index("GuidDocument", Name = "IXFK_CfdiRelacionados_Comprobante")]
    public partial class CfdiRelacionados
    {
        public Guid GuidDocument { get; set; }
        public Guid UUID { get; set; }
        [StringLength(60)]
        [Unicode(false)]
        public string? TipoRelacion { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? TipoRelacionDesc { get; set; }

        [ForeignKey("GuidDocument")]
        public virtual Comprobante GuidDocumentNavigation { get; set; } = null!;
    }
}
