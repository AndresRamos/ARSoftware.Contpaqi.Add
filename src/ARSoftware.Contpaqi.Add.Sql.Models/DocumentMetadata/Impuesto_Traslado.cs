using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    public partial class Impuesto_Traslado
    {
        public Guid GuidDocument { get; set; }
        public string? Impuesto { get; set; }
        public string? ImpuestoDesc { get; set; }
        public string? TipoFactor { get; set; }
        public string? TasaOCuota { get; set; }
        public decimal? Importe { get; set; }

        public virtual Comprobante GuidDocumentNavigation { get; set; } = null!;
    }
}
