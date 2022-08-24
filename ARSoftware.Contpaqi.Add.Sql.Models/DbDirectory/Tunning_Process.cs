using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    [Keyless]
    public partial class Tunning_Process
    {
        public Guid GuidProcess { get; set; }
        public Guid GuidCompany { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        public int? TruncatedLogs { get; set; }
        public int? ReorganicedIdx { get; set; }
        public int? RebuildedIdx { get; set; }
        public byte? UpdStatix { get; set; }
    }
}
