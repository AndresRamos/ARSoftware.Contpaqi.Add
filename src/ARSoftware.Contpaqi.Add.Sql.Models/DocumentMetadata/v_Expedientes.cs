using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    [Keyless]
    public partial class v_Expedientes
    {
        public Guid? Guid_Exp { get; set; }
        public Guid? Guid_Rel { get; set; }
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
