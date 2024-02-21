using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata;

public partial class Doc_App
{
    public Guid GuidDocument { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Tipo { get; set; }

    public string? Subtipo { get; set; }

    public int? Ejercicio { get; set; }

    public int? Periodo { get; set; }

    public string? Numero { get; set; }

    public string? SubTipoNumero { get; set; }

    public string? Cuenta { get; set; }

    public string? Folio { get; set; }

    public int? Responsable { get; set; }

    public virtual Documento GuidDocumentNavigation { get; set; } = null!;
}
