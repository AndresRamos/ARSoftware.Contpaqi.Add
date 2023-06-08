using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata
{
    [Keyless]
    public partial class EFOS_RFC
    {
        [StringLength(13)]
        [Unicode(false)]
        public string? RFC { get; set; }
    }
}
