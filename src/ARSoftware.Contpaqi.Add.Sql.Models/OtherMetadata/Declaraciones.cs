using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata
{
    public partial class Declaraciones
    {
        public Guid GuidDocument { get; set; }
        public int? Mes { get; set; }
        public int? Anio { get; set; }
        public DateTime? EmisionDateDeclaracion { get; set; }
        public string? OperationNum { get; set; }
        public Guid? PdfAcknowledgementGuid { get; set; }
        public Guid? XmlAcknowledgementGuid { get; set; }
        public string? PeriodDesc { get; set; }
        public string? FileName { get; set; }
        public string? ValidationStatus { get; set; }
        public string? RFC { get; set; }
        public string? TipoEnvio { get; set; }
        public string? TipoSolicitud { get; set; }
        public string? NumOrden { get; set; }
        public string? NumTramite { get; set; }

        public virtual Documento GuidDocumentNavigation { get; set; } = null!;
    }
}
