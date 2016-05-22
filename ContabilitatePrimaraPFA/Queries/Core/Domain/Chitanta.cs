namespace Queries.Core.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Chitanta")]
    public partial class Chitanta
    {
        public int ChitantaId { get; set; }

        [Required]
        [StringLength(4)]
        public string SerieChitanta { get; set; }

        [Column("Nr.Chitanta")]
        [Required]
        [StringLength(6)]
        public string NrChitanta { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataEmiterii { get; set; }
        [Column("Plata Numerar")]
        public bool PlataNumerar { get; set; }

        public int FacturaId { get; set; }

        public virtual Factura Factura { get; set; }
    }
}
