using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Models.OtherMetadata
{
    [Index("GuidDocument", Name = "IXFK_Doc_App")]
    public partial class Doc_App
    {
        [Key]
        public Guid GuidDocument { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? Tipo { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Subtipo { get; set; }
        public int? Ejercicio { get; set; }
        public int? Periodo { get; set; }
        [StringLength(40)]
        public string? Numero { get; set; }
        [StringLength(40)]
        public string? SubTipoNumero { get; set; }
        [StringLength(36)]
        [Unicode(false)]
        public string? Cuenta { get; set; }
        [StringLength(40)]
        public string? Folio { get; set; }
        public int? Responsable { get; set; }

        [ForeignKey("GuidDocument")]
        [InverseProperty("Doc_App")]
        public virtual Documento GuidDocumentNavigation { get; set; } = null!;
    }
}
