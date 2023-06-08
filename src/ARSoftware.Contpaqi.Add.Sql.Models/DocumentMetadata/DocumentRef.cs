using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    [Keyless]
    [Index("GuidDocument", "ApplicationType", "Comment", Name = "IXFKNC_DocumentRef_Documento")]
    public partial class DocumentRef
    {
        public Guid GuidDocument { get; set; }
        public Guid? Guid { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string? AggregationType { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string? ApplicationType { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Comment { get; set; }
    }
}
