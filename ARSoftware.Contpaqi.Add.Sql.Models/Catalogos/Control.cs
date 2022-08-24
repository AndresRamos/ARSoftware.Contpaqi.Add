using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.Catalogos
{
    [Keyless]
    public partial class Control
    {
        public int IdCatalogo { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? Catalogo { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string? Version { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaLanzamiento { get; set; }
        [StringLength(60)]
        [Unicode(false)]
        public string? Storage { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? TagReporting { get; set; }
    }
}
