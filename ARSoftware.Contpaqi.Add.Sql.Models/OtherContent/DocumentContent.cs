using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherContent
{
    [Index("GuidDocument", Name = "IXFK_DocumentContent")]
    public partial class DocumentContent
    {
        [Key]
        public Guid GuidDocument { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? DocumentType { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? FileName { get; set; }
        [Column(TypeName = "text")]
        public string? Content { get; set; }
        [StringLength(2)]
        [Unicode(false)]
        public string? SubDirectory { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocumentDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
    }
}
