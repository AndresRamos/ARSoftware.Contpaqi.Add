using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata
{
    [Keyless]
    [Index("Guid_Relacionado", Name = "IXFK_Expedientes_Documento")]
    [Index("Guid_Pertenece", Name = "NC_Expedientes_GuidPertenece")]
    public partial class Expedientes
    {
        public Guid Guid_Relacionado { get; set; }
        public Guid? Guid_Pertenece { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? ApplicationType_Exp { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? Type_Exp { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Comment_Exp { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeStamp_Exp { get; set; }
    }
}
