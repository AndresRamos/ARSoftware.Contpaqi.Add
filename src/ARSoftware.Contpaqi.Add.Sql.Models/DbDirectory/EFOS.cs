using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DbDirectory
{
    [Keyless]
    [Index("No", "RFC", "Nombre", Name = "IXNC_EFOS")]
    public partial class EFOS
    {
        public int No { get; set; }
        [StringLength(13)]
        [Unicode(false)]
        public string? RFC { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Nombre { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? Situacion { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? NoPublica { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PubSATPresuntos { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string? NumGlobPres { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PubDOFPresuntos { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PubSatDesvir { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string? NumGlobContDesv { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string? PubDofDesvir { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string? NumGlobDef { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PubSATDef { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PubDofDef { get; set; }
    }
}
