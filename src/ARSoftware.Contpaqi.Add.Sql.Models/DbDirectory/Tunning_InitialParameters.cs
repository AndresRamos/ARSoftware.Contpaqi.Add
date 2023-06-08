using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    public partial class Tunning_InitialParameters
    {
        public string? DBTemplate { get; set; }
        public int? LogSize { get; set; }
        public decimal? LogLevel1 { get; set; }
        public decimal? LogLevel2 { get; set; }
        public decimal? LogLevel3 { get; set; }
        public decimal? IdxLevel1 { get; set; }
        public decimal? IdxLevel2 { get; set; }
        public decimal? IdxLevel3 { get; set; }
    }
}
