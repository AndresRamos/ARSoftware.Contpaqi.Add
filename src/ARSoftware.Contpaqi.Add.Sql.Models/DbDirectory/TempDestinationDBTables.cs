using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    public partial class TempDestinationDBTables
    {
        public int? Id { get; set; }
        public string? TableName { get; set; }
        public long? ObjectId { get; set; }
        public byte? TableLevel { get; set; }
    }
}
