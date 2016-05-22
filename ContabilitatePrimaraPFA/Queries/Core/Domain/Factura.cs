namespace Queries.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Factura")]
    public class Factura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Factura()
        {
            // ReSharper disable once DoNotCallOverridableMethodsInConstructor
            Chitanta = new HashSet<Chitanta>();
        }

        public int FacturaId { get; set; }

        [Required]
        [StringLength(4)]
        public string SerieFactura { get; set; }

        [Column("NrFactura")]
        [Required]
        [StringLength(6)]
        public string NrFactura { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataFactura { get; set; }
        [Column("Pret + T.V.A.")]
        public decimal Pret { get; set; }
        [Column("Valoare T.V.A.")]
        public decimal Tva { get; set; }
        [Column("Achizitie/Vanzare")]
        public bool EsteIncasare { get; set; }
        [Column("Plateste T.V.A")]
        public bool PlatitorTva { get; set; }

        public int? ContractId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitanta> Chitanta { get; set; }

        public virtual Contract Contract { get; set; }
    }
}
