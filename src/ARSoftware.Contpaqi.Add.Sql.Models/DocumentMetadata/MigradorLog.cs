using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    [Keyless]
    public partial class MigradorLog
    {
        public long IdLog { get; set; }
        public Guid? GuidDocument { get; set; }
        [Unicode(false)]
        public string? ErrorMessage { get; set; }
        [Unicode(false)]
        public string? FileName { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Origen { get; set; }
    }
}
