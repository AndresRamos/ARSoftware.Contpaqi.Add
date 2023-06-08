using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata
{
    public partial class Certificates
    {
        public Guid GuidDocument { get; set; }
        public string? LlavePublica { get; set; }
        public string? LlavePrivada { get; set; }
        public string? NumeroSerie { get; set; }
        public DateTime? FechaInicial { get; set; }
        public DateTime? FechaFinal { get; set; }
        public string? SubjectName { get; set; }
        public string? IssuerName { get; set; }
        public string? ActualCSDStatus { get; set; }
        public bool? IsTesting { get; set; }
    }
}
