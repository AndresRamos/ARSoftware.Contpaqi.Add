using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    [Keyless]
    [Index("GuidProcess_Merge", "GuidMigrateProcess", "GuidCompanySource", "GuidCompanyDestination", "CancelMerge", Name = "IXNC_MergeProcess")]
    public partial class MergeProcess
    {
        public Guid? GuidProcess_Merge { get; set; }
        public Guid? GuidMigrateProcess { get; set; }
        public Guid? GuidCompanySource { get; set; }
        public Guid? GuidCompanyDestination { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDateProcess { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDateProcess { get; set; }
        public byte? CancelMerge { get; set; }
    }
}
