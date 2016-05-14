namespace Queries.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Beneficiar")]
    public partial class Beneficiar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Beneficiar()
        {
            Contract = new HashSet<Contract>();
        }

        public int BeneficiarId { get; set; }

        [Required]
        [StringLength(40)]
        public string Nume { get; set; }

        [Required]
        [StringLength(50)]
        public string Prenume { get; set; }

        [Required]
        [StringLength(14)]
        public string CNP { get; set; }

        public int? TipActId { get; set; }

        [Required]
        [StringLength(3)]
        public string Serie { get; set; }

        [Required]
        [StringLength(6)]
        public string Numar { get; set; }

        [Column(TypeName = "text")]
        public string Adresa { get; set; }

        public virtual TipAct TipAct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contract { get; set; }
    }
}
