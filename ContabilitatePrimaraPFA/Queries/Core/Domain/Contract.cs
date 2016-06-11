namespace Queries.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Contract")]
    public partial class Contract
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contract()
        {
            Plata = new HashSet<Plata>();
            Incasare = new HashSet<Incasare>();
            Lucrare = new HashSet<Lucrare>();
        }

        public int ContractId { get; set; }

        [Required]
        [StringLength(4)]
        public string NrContract { get; set; }

        [Column(TypeName = "date")]
        public DateTime Data { get; set; }

        public int? BeneficiarId { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string ObiectulContractului { get; set; }

        public decimal Suma { get; set; }

        [Column(TypeName = "text")]
        public string Observatii { get; set; }

        public virtual Beneficiar Beneficiar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plata> Plata { get; set; }
        public virtual ICollection<Incasare> Incasare { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lucrare> Lucrare { get; set; }
    }
}
