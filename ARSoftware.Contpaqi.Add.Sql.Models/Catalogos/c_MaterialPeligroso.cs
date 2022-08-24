using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.Catalogos
{
    [Keyless]
    [Index("CodigoReporting", "Valor", Name = "IXNCR_c_MaterialPeligroso")]
    [Index("Codigo", "Valor", Name = "IXNC_c_MaterialPeligroso")]
    public partial class c_MaterialPeligroso
    {
        public long IdElemento { get; set; }
        public int? IdCatalogo { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string Codigo { get; set; } = null!;
        [StringLength(20)]
        [Unicode(false)]
        public string CodigoReporting { get; set; } = null!;
        [StringLength(512)]
        [Unicode(false)]
        public string? Valor { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InicioVigencia { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FinVigencia { get; set; }
    }
}
