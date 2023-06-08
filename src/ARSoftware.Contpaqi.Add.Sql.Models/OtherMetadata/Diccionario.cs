using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata
{
    [Keyless]
    public partial class Diccionario
    {
        public long Id { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Label { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Field { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Table { get; set; }
    }
}
