using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    public partial class Schema_T_Log
    {
        public int IdDataBase { get; set; }
        public string? DataBaseName { get; set; }
        public string? ComponentName { get; set; }
        public string? IdObject { get; set; }
        public string? Action { get; set; }
    }
}
