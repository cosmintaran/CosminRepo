namespace Queries.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipAct")]
    public partial class TipAct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipAct()
        {
            Beneficiar = new HashSet<Beneficiar>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte TipActId { get; set; }

        [Column("TipAct")]
        [Required]
        [StringLength(22)]
        public string TipAct1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Beneficiar> Beneficiar { get; set; }
    }
}
