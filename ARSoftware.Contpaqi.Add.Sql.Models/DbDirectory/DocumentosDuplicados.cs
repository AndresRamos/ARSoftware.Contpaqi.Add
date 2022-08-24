using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    [Keyless]
    public partial class DocumentosDuplicados
    {
        public Guid? GuidProcess { get; set; }
        public Guid? GuidDocumentDuplicado { get; set; }
        public Guid? UUID { get; set; }
        public Guid? GuidDocumentInDB { get; set; }
        public int? IDProcesso { get; set; }
    }
}
