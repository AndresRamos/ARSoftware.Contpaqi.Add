using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata
{
    public partial class cat_TipoDocumento
    {
        public cat_TipoDocumento()
        {
            Documento = new HashSet<Documento>();
        }

        public int IdTipoDocumento { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<Documento> Documento { get; set; }
    }
}
