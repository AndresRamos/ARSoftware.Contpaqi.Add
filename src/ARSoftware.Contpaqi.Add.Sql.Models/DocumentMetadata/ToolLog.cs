using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    [Keyless]
    public partial class ToolLog
    {
        public Guid? GuidProcess { get; set; }
        [Unicode(false)]
        public string? NombreEmpresa { get; set; }
        [StringLength(15)]
        [Unicode(false)]
        public string? RFC { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? RangoFechas { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Operacion { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? FechaEjecucion { get; set; }
        [Unicode(false)]
        public string? DetalleOperacion { get; set; }
        public int? TotalReferencias { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? FechaFinEjecucion { get; set; }
    }
}
