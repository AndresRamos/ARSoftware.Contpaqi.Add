using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    [Keyless]
    [Index("ID_Type", "MetaType", "DBStorage", Name = "IXFKNC_Cat_MetaType")]
    public partial class Cat_MetaType
    {
        public int? ID_Type { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? MetaType { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? DBStorage { get; set; }
    }
}
