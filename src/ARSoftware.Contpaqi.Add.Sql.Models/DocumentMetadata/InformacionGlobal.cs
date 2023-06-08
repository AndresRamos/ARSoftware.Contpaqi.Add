using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    public partial class InformacionGlobal
    {
        public Guid GuidDocument { get; set; }
        public string? Periodicidad { get; set; }
        public string? PeriodicidadDesc { get; set; }
        public string? Meses { get; set; }
        public string? MesesDesc { get; set; }
        public int? Anio { get; set; }

        public virtual Comprobante GuidDocumentNavigation { get; set; } = null!;
    }
}
