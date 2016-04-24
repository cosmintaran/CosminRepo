namespace Queries.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Factura")]
    public partial class Factura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Factura()
        {
            Chitanta = new HashSet<Chitanta>();
        }

        public long FacturaId { get; set; }

        [Column("Serie Factura")]
        [Required]
        [StringLength(4)]
        public string Serie_Factura { get; set; }

        [Column("Nr. Factura")]
        [Required]
        [StringLength(5)]
        public string Nr__Factura { get; set; }

        [Column("Data Factura", TypeName = "date")]
        public DateTime Data_Factura { get; set; }

        public decimal Suma { get; set; }

        public long? ContractId { get; set; }

        public bool Plata { get; set; }

        [Column("Platitor TVA")]
        public bool Platitor_TVA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitanta> Chitanta { get; set; }

        public virtual Contract Contract { get; set; }
    }
}
