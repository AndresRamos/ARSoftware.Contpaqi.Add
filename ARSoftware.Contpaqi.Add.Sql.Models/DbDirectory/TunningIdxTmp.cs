using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    [Keyless]
    public partial class TunningIdxTmp
    {
        [StringLength(255)]
        [Unicode(false)]
        public string? TableName { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? IdxName { get; set; }
        public int? PercentageFrag { get; set; }
    }
}
