using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    [Keyless]
    public partial class TempDestinationDBTables
    {
        public int? Id { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? TableName { get; set; }
        public long? ObjectId { get; set; }
        public byte? TableLevel { get; set; }
    }
}
