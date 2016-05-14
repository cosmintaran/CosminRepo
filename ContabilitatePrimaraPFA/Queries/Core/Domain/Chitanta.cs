namespace Queries.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

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
        public string Nr_Chitanta { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataEmiterii { get; set; }

        public int FacturaId { get; set; }

        public virtual Factura Factura { get; set; }
    }
}
