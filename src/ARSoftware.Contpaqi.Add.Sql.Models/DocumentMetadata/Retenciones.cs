using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata;

public partial class Retenciones
{
    public Guid GuidDocument { get; set; }

    public string? Nacionalidad { get; set; }

    public string? NumRegIdTrib { get; set; }

    public int? MesIni { get; set; }

    public int? MesFin { get; set; }

    public int? Ejerc { get; set; }

    public decimal? MontoTotOperacion { get; set; }

    public decimal? MontoTotGrav { get; set; }

    public decimal? MontoTotExent { get; set; }

    public decimal? MontoTotRet { get; set; }

    public string? Version { get; set; }

    public string? Folio { get; set; }

    public string? Sello { get; set; }

    public string? NumCert { get; set; }

    public DateTime? FechaExp { get; set; }

    public string? CveRetenc { get; set; }

    public string? DescRetenc { get; set; }

    public string? RFCEmisor { get; set; }

    public string? NomDenRazSocE { get; set; }

    public string? CURPE { get; set; }

    public string? RFCRecep { get; set; }

    public string? NomDenRazSocR { get; set; }

    public string? CURPR { get; set; }

    public string? NomDenRazSocRExt { get; set; }

    public Guid? UUID { get; set; }

    public string? LugarExp { get; set; }

    public string? LugarExpDesc { get; set; }

    public Guid? UUIDRelacionado { get; set; }

    public string? TipoRelacion { get; set; }

    public string? TipoRelacionDesc { get; set; }

    public string? RegimenEmisor { get; set; }

    public string? RegimenEmisorDesc { get; set; }

    public string? DomicilioReceptor { get; set; }

    public decimal? UtilidadBimestral { get; set; }

    public decimal? ISRCorrespondiente { get; set; }

    public virtual Documento GuidDocumentNavigation { get; set; } = null!;

    public virtual ICollection<RetencionesXImp> RetencionesXImp { get; set; } = new List<RetencionesXImp>();
}
