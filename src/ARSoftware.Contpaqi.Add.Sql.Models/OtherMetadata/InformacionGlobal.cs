using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata
{
    [Keyless]
    [Index("GuidDocument", Name = "IXFK_Info_Global")]
    public partial class InformacionGlobal
    {
        public Guid GuidDocument { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? Periodicidad { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? PeriodicidadDesc { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? Meses { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? MesesDesc { get; set; }
        public int? Anio { get; set; }

        [ForeignKey("GuidDocument")]
        public virtual Comprobante GuidDocumentNavigation { get; set; } = null!;
    }
}
