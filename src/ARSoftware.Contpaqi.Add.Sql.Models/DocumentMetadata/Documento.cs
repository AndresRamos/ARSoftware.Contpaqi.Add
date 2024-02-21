using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata;

public partial class Documento
{
    public Guid GuidDocument { get; set; }

    public string? Path { get; set; }

    public string? Hash { get; set; }

    public string? Status { get; set; }

    public string? MetadataEstatusApp { get; set; }

    public string? UserResponsibleApp { get; set; }

    public string? ReferenceApp { get; set; }

    public string? NotesApp { get; set; }

    public DateTime? TimeStamp { get; set; }

    public string? ProcessApp { get; set; }

    public string? NoPaymentStatusapp { get; set; }

    public string? ClaveDescripcion { get; set; }

    public string? SourceFile { get; set; }

    public string? Type_Otro { get; set; }

    public string? Type_Ext { get; set; }

    public int? IdTipoDocumento { get; set; }

    public DateTime? StartPeriodDate { get; set; }

    public DateTime? EndPeriodDate { get; set; }

    public long? Period { get; set; }

    public int? Year { get; set; }

    public decimal? TotalPayRoll { get; set; }

    public string? SalaryType { get; set; }

    public DateTime? EmisionDate { get; set; }

    public string? Type { get; set; }

    public byte? IsAsoContabilidad { get; set; }

    public byte? IsAsoComercial { get; set; }

    public byte? IsAsoBancos { get; set; }

    public string? ValidationStatus { get; set; }

    public DateTime? CancelDate { get; set; }

    public string? CancelStatus { get; set; }

    public virtual Comprobante? Comprobante { get; set; }

    public virtual Declaraciones? Declaraciones { get; set; }

    public virtual Doc_App? Doc_App { get; set; }

    public virtual cat_TipoDocumento? IdTipoDocumentoNavigation { get; set; }

    public virtual Retenciones? Retenciones { get; set; }
}
