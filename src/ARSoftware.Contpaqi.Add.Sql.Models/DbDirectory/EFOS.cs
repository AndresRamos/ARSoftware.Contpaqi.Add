using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    public partial class EFOS
    {
        public int No { get; set; }
        public string? RFC { get; set; }
        public string? Nombre { get; set; }
        public string? Situacion { get; set; }
        public string? NoPublica { get; set; }
        public DateTime? PubSATPresuntos { get; set; }
        public string? NumGlobPres { get; set; }
        public DateTime? PubDOFPresuntos { get; set; }
        public DateTime? PubSatDesvir { get; set; }
        public string? NumGlobContDesv { get; set; }
        public string? PubDofDesvir { get; set; }
        public string? NumGlobDef { get; set; }
        public DateTime? PubSATDef { get; set; }
        public DateTime? PubDofDef { get; set; }
    }
}
