using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory;

public partial class DatabaseDirectory
{
    public long idDataBase { get; set; }

    public Guid GuidCompany { get; set; }

    public string? Version { get; set; }

    public string? NombreEmpresa { get; set; }

    public string? DB_DocumentsMetadata { get; set; }

    public decimal? Ver_DocumentsMetadata { get; set; }

    public string? DB_DocumentsContent { get; set; }

    public decimal? Ver_DocumentsContent { get; set; }

    public string? DB_OthersMetadata { get; set; }

    public decimal? Ver_OthersMetadata { get; set; }

    public string? DB_OthersContent { get; set; }

    public decimal? Ver_OthersContent { get; set; }

    public DateTime? Syncronized { get; set; }

    public string? Accesibility { get; set; }

    public DateTime? TimeStamp { get; set; }

    public string? Alias { get; set; }

    public string? RFC { get; set; }

    public string? CompanyPath { get; set; }
}
