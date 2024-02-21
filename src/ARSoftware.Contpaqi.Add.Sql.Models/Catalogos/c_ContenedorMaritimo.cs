using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.Catalogos;

public partial class c_ContenedorMaritimo
{
    public long IdElemento { get; set; }

    public int? IdCatalogo { get; set; }

    public string Codigo { get; set; } = null!;

    public string CodigoReporting { get; set; } = null!;

    public string? Valor { get; set; }

    public DateTime? InicioVigencia { get; set; }

    public DateTime? FinVigencia { get; set; }
}
