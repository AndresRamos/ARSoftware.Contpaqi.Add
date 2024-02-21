using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata;

public partial class ToolLog
{
    public Guid? GuidProcess { get; set; }

    public string? NombreEmpresa { get; set; }

    public string? RFC { get; set; }

    public string? RangoFechas { get; set; }

    public string? Operacion { get; set; }

    public string? FechaEjecucion { get; set; }

    public string? DetalleOperacion { get; set; }

    public int? TotalReferencias { get; set; }

    public string? FechaFinEjecucion { get; set; }
}
