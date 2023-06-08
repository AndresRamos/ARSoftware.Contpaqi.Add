using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    public partial class Diccionario
    {
        public long Id { get; set; }
        public string? Label { get; set; }
        public string? Field { get; set; }
        public string? Table { get; set; }
    }
}
