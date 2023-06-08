using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    public partial class MergeProcess
    {
        public Guid? GuidProcess_Merge { get; set; }
        public Guid? GuidMigrateProcess { get; set; }
        public Guid? GuidCompanySource { get; set; }
        public Guid? GuidCompanyDestination { get; set; }
        public DateTime? StartDateProcess { get; set; }
        public DateTime? EndDateProcess { get; set; }
        public byte? CancelMerge { get; set; }
    }
}
