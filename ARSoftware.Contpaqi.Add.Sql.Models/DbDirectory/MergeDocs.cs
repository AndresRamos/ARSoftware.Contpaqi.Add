using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    [Keyless]
    [Index("GuidProcess_Merge", "GuidDocument", "Storage", "DocType", "Operation", "UUID", Name = "IXNC_MergeProcess")]
    [Index("GuidProcess_Merge", "Operation", "GuidDocument", Name = "NC_MergeProcess_Operation")]
    [Index("GuidProcess_Merge", "GuidDocument", Name = "NC_Process_Document")]
    public partial class MergeDocs
    {
        public Guid? GuidProcess_Merge { get; set; }
        public Guid? GuidCompanySource { get; set; }
        public Guid? GuidCompanyDestination { get; set; }
        public Guid? GuidDocument { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Storage { get; set; }
        [StringLength(25)]
        [Unicode(false)]
        public string? DocType { get; set; }
        public byte? Operation { get; set; }
        public Guid? UUID { get; set; }
        public Guid? GuidDocumentDest { get; set; }
    }
}
