using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata
{
    [Keyless]
    public partial class TempAsocTool
    {
        [StringLength(36)]
        public string? GuidRef { get; set; }
        [StringLength(36)]
        public string? UUID { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string? Sistema { get; set; }
        [StringLength(220)]
        public string? TipoPol { get; set; }
        [StringLength(6)]
        [Unicode(false)]
        public string? TipoCheq { get; set; }
        public int? Ejercicio { get; set; }
        public int? Periodo { get; set; }
        [StringLength(40)]
        public string? Folio { get; set; }
        [StringLength(60)]
        [Unicode(false)]
        public string? Cuenta { get; set; }
        [StringLength(60)]
        [Unicode(false)]
        public string? Tipo { get; set; }
        public Guid? GuidDocADD { get; set; }
        [StringLength(25)]
        [Unicode(false)]
        public string? TipoDoc { get; set; }
    }
}
