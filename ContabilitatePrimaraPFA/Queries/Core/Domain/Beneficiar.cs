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
            Lucrare = new HashSet<Lucrare>();
        }

        public long BeneficiarId { get; set; }

        [Required]
        [StringLength(40)]
        public string Nume { get; set; }

        [Required]
        [StringLength(50)]
        public string Prenume { get; set; }

        public long CNP { get; set; }

        public byte? TipActId { get; set; }

        [Required]
        [StringLength(3)]
        public string Serie { get; set; }

        [Required]
        [StringLength(5)]
        public string Numar { get; set; }

        [Column(TypeName = "text")]
        public string Adresa { get; set; }

        public virtual TipAct TipAct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contract { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lucrare> Lucrare { get; set; }
    }
}
