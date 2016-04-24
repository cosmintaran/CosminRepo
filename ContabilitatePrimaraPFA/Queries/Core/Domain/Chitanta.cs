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
        public long ChitantaId { get; set; }

        [Column("Serie Chitanta")]
        [Required]
        [StringLength(4)]
        public string Serie_Chitanta { get; set; }

        [Column("NR. Chitanta")]
        [Required]
        [StringLength(6)]
        public string NR__Chitanta { get; set; }

        [Column("Data Emiterii", TypeName = "date")]
        public DateTime Data_Emiterii { get; set; }

        public long? FacturaId { get; set; }

        public virtual Factura Factura { get; set; }
    }
}
