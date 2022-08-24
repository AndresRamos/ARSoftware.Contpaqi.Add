using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    [Keyless]
    public partial class TempDestinationDBDetail
    {
        public int Id { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? TblName { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? ColName { get; set; }
        public int? ColOrd { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? ColType { get; set; }
        public int? ColLen { get; set; }
        public int? ColPre { get; set; }
        public int? ColSca { get; set; }
    }
}
