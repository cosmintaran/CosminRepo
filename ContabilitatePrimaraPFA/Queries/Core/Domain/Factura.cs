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

        public int FacturaId { get; set; }

        [Required]
        [StringLength(4)]
        public string SerieFactura { get; set; }

        [Column("Nr.Factura")]
        [Required]
        [StringLength(6)]
        public string Nr_Factura { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataFactura { get; set; }

        public decimal Suma { get; set; }

        public int? ContractId { get; set; }

        public bool Plata { get; set; }

        public bool PlatitorTVA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitanta> Chitanta { get; set; }

        public virtual Contract Contract { get; set; }
    }
}
