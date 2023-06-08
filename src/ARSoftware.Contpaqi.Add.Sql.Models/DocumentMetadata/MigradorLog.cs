using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    public partial class MigradorLog
    {
        public long IdLog { get; set; }
        public Guid? GuidDocument { get; set; }
        public string? ErrorMessage { get; set; }
        public string? FileName { get; set; }
        public string? Origen { get; set; }
    }
}
