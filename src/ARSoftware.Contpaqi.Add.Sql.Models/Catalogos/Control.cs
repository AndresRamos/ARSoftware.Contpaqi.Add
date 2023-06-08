using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.Catalogos
{
    public partial class Control
    {
        public int IdCatalogo { get; set; }
        public string? Catalogo { get; set; }
        public string? Version { get; set; }
        public DateTime? FechaLanzamiento { get; set; }
        public string? Storage { get; set; }
        public string? TagReporting { get; set; }
    }
}
