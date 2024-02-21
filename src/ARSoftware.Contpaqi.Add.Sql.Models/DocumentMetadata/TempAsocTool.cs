using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata;

public partial class TempAsocTool
{
    public string? GuidRef { get; set; }

    public string? UUID { get; set; }

    public string? Sistema { get; set; }

    public string? TipoPol { get; set; }

    public string? TipoCheq { get; set; }

    public int? Ejercicio { get; set; }

    public int? Periodo { get; set; }

    public string? Folio { get; set; }

    public string? Cuenta { get; set; }

    public string? Tipo { get; set; }

    public Guid? GuidDocADD { get; set; }

    public string? TipoDoc { get; set; }
}
