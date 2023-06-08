using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    public partial class Impuesto_Traslado_Concepto
    {
        public string IdConcepto { get; set; } = null!;
        public decimal? Base { get; set; }
        public string? Impuesto { get; set; }
        public string? ImpuestoDesc { get; set; }
        public string? TipoFactor { get; set; }
        public string? TasaOCuota { get; set; }
        public decimal? Importe { get; set; }

        public virtual Conceptos IdConceptoNavigation { get; set; } = null!;
    }
}
