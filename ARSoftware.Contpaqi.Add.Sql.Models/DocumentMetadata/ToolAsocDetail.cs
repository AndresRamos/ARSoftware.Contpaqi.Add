using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    [Keyless]
    public partial class ToolAsocDetail
    {
        public Guid? GuidExp { get; set; }
        public int? Comercial { get; set; }
        public int? Contabilidad { get; set; }
        public int? Bancos { get; set; }
    }
}
