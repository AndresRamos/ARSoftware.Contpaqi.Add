using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata
{
    [Keyless]
    public partial class ExpTool
    {
        public Guid? Guid_Relacionado { get; set; }
        public Guid? Guid_Pertenece { get; set; }
    }
}
