using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    public partial class DocRel_RetencionesDR_Pago
    {
        public string IdPago { get; set; } = null!;
        public Guid IdDoctoUnique { get; set; }
        public decimal? BaseDR { get; set; }
        public string? ImpuestoDR { get; set; }
        public string? ImpuestoDRDesc { get; set; }
        public string? TipoFactorDR { get; set; }
        public decimal? TasaOCuotaDR { get; set; }
        public decimal? ImporteDR { get; set; }

        public virtual Pagos_Doc_Rel Id { get; set; } = null!;
    }
}
