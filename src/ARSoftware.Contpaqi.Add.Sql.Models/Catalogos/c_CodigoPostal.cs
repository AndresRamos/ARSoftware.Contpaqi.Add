using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.Catalogos
{
    [Keyless]
    [Index("Codigo", "Valor", Name = "IXNC_CodigoPostal")]
    public partial class c_CodigoPostal
    {
        public long IdElemento { get; set; }
        public int? IdCatalogo { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string Codigo { get; set; } = null!;
        [StringLength(255)]
        [Unicode(false)]
        public string? Valor { get; set; }
    }
}
