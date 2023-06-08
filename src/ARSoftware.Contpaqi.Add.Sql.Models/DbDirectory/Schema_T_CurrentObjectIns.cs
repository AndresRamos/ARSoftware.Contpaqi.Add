using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    [Keyless]
    public partial class Schema_T_CurrentObjectIns
    {
        [Unicode(false)]
        public string? InsertSQLCommand { get; set; }
    }
}
