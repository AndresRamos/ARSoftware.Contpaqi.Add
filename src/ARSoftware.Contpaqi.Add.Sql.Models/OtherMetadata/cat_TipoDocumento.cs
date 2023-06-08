using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata
{
    [Index("IdTipoDocumento", "Descripcion", Name = "IXFKNC_Documento_cat_TipoDocumento")]
    public partial class cat_TipoDocumento
    {
        public cat_TipoDocumento()
        {
            Documento = new HashSet<Documento>();
        }

        [Key]
        public int IdTipoDocumento { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Descripcion { get; set; }

        [InverseProperty("IdTipoDocumentoNavigation")]
        public virtual ICollection<Documento> Documento { get; set; }
    }
}
