namespace Queries.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contract")]
    public partial class Contract
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contract()
        {
            Factura = new HashSet<Factura>();
            Lucrare = new HashSet<Lucrare>();
        }

        public long ContractId { get; set; }

        [Required]
        [StringLength(4)]
        public string NrContract { get; set; }

        [Column(TypeName = "date")]
        public DateTime Data { get; set; }

        public long? BeneficiarId { get; set; }

        [Column("Scopul/Obiectul Contractului", TypeName = "text")]
        [Required]
        public string Scopul_Obiectul_Contractului { get; set; }

        public decimal Suma { get; set; }

        [Column(TypeName = "text")]
        public string Observatii { get; set; }

        public virtual Beneficiar Beneficiar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Factura> Factura { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lucrare> Lucrare { get; set; }
    }
}
