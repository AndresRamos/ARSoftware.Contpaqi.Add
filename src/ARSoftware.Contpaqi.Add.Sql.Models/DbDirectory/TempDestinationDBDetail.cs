using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    public partial class TempDestinationDBDetail
    {
        public int Id { get; set; }
        public string? TblName { get; set; }
        public string? ColName { get; set; }
        public int? ColOrd { get; set; }
        public string? ColType { get; set; }
        public int? ColLen { get; set; }
        public int? ColPre { get; set; }
        public int? ColSca { get; set; }
    }
}
