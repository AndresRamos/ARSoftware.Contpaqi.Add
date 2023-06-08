using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    public partial class RetencionesXImp
    {
        public Guid GuidDocument { get; set; }
        public string IdImpuestoRet { get; set; } = null!;
        public decimal? BaseRet { get; set; }
        public string? Impuesto { get; set; }
        public string? ImpuestoDesc { get; set; }
        public decimal? montoRet { get; set; }
        public string? TipoPagoRet { get; set; }

        public virtual Retenciones GuidDocumentNavigation { get; set; } = null!;
    }
}
