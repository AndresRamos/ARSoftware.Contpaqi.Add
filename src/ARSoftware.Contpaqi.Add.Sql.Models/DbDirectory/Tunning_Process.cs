using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    public partial class Tunning_Process
    {
        public Guid GuidProcess { get; set; }
        public Guid GuidCompany { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? TruncatedLogs { get; set; }
        public int? ReorganicedIdx { get; set; }
        public int? RebuildedIdx { get; set; }
        public byte? UpdStatix { get; set; }
    }
}
