using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    [Keyless]
    [Index("GuidDocument", Name = "IXFK_DocumentStatus")]
    public partial class DocumentStatus
    {
        public Guid GuidDocument { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? IdError { get; set; }
        public string? ErrorDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LlastmodifiedDate { get; set; }
        public int? Status { get; set; }
    }
}
