using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    public partial class EFOS_Version
    {
        public int Type { get; set; }
        public string? Version { get; set; }
        public string? URL { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
