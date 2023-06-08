using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata
{
    public partial class Impuestos_Locales
    {
        public Impuestos_Locales()
        {
            Impuestos_Retenciones_Locales = new HashSet<Impuestos_Retenciones_Locales>();
            Impuestos_Traslados_Locales = new HashSet<Impuestos_Traslados_Locales>();
        }

        public Guid GuidDocument { get; set; }
        public decimal? Version { get; set; }
        public decimal? TotalRetenciones { get; set; }
        public decimal? TotalTraslados { get; set; }

        public virtual Comprobante GuidDocumentNavigation { get; set; } = null!;
        public virtual ICollection<Impuestos_Retenciones_Locales> Impuestos_Retenciones_Locales { get; set; }
        public virtual ICollection<Impuestos_Traslados_Locales> Impuestos_Traslados_Locales { get; set; }
    }
}
