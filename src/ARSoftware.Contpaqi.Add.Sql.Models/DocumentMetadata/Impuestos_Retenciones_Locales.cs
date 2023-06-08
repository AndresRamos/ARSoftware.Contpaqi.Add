using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    public partial class Impuestos_Retenciones_Locales
    {
        public Guid GuidDocument { get; set; }
        public string ImpDetalle { get; set; } = null!;
        public string? ImpLocalRetenido { get; set; }
        public decimal? TasadeRetencion { get; set; }
        public decimal? ImporteRetenido { get; set; }

        public virtual Impuestos_Locales GuidDocumentNavigation { get; set; } = null!;
    }
}
