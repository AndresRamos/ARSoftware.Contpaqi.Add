using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata;

public partial class MetadataDuplicados
{
    public Guid? GuidDocument { get; set; }

    public Guid? GuidDocumentDuplicado { get; set; }

    public string? MetadataEstatusApp { get; set; }

    public string? UserResponsibleApp { get; set; }

    public string? ReferenceApp { get; set; }

    public string? NotesApp { get; set; }

    public string? ProcessApp { get; set; }

    public DateTime? StartPeriodDate { get; set; }

    public DateTime? EndPeriodDate { get; set; }

    public long? Period { get; set; }

    public int? Year { get; set; }

    public decimal? TotalPayRoll { get; set; }

    public string? SalaryType { get; set; }
}
