using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    [Keyless]
    [Index("GuidControl", "Id_Process", "StatusProcess", "TotalExtracted", "Percentage", "TotalProcessed", Name = "IXNC_ProcessControl")]
    public partial class ProcessControl
    {
        public Guid GuidControl { get; set; }
        public Guid? GuidCompany { get; set; }
        public int? Id_Process { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? ProcessDescription { get; set; }
        public int? Percentage { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        public int? TotalExtracted { get; set; }
        public int? TotalProcessed { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? LogName { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? StatusProcess { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? JSONName { get; set; }

        [ForeignKey("Id_Process")]
        public virtual Cat_Process? Id_ProcessNavigation { get; set; }
    }
}
