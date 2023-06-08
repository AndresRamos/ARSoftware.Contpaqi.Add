using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    public partial class EntidadSCNF
    {
        public Guid GuidDocument { get; set; }
        public string IdEntidadSCNF { get; set; } = null!;
        public string? OrigenRecurso { get; set; }
        public string? OrigenRecursoDesc { get; set; }
        public decimal? MontoRecursoPropio { get; set; }

        public virtual Nomina GuidDocumentNavigation { get; set; } = null!;
    }
}
