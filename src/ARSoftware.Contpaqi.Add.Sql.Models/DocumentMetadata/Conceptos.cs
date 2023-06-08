using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Add.Sql.Models.DocumentMetadata
{
    public partial class Conceptos
    {
        public Conceptos()
        {
            Partes = new HashSet<Partes>();
        }

        public Guid GuidDocument { get; set; }
        public string IdConcepto { get; set; } = null!;
        public string? CveProdSer { get; set; }
        public string? CveProdSerDesc { get; set; }
        public string? NoIdentificacion { get; set; }
        public decimal? Cantidad { get; set; }
        public string? ClaveUnidad { get; set; }
        public string? ClaveUnidadDesc { get; set; }
        public string? Unidad { get; set; }
        public string? Descripcion { get; set; }
        public decimal? ValorUnitario { get; set; }
        public decimal? Importe { get; set; }
        public decimal? Descuento { get; set; }
        public string? ObjetoImp { get; set; }
        public string? ObjetoImpDesc { get; set; }
        public string? RFCCtaTercero { get; set; }
        public string? NombreCtaTercero { get; set; }
        public string? RegimenFiscalCtaTercero { get; set; }
        public string? RegimenFiscalCtaTerceroDesc { get; set; }
        public string? DomicilioFiscalCtaTercero { get; set; }

        public virtual Comprobante GuidDocumentNavigation { get; set; } = null!;
        public virtual ICollection<Partes> Partes { get; set; }
    }
}
