namespace Queries.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipLucrare")]
    public partial class TipLucrare
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipLucrare()
        {
           Lucrare = new HashSet<Lucrare>();
        }

        public int TipLucrareId { get; set; }

        [Column("Cod Lucrare")]
        [Required]
        [StringLength(5)]
        public string Cod_Lucrare { get; set; }

        [Column("Tip Lucrare")]
        [Required]
        [StringLength(125)]
        public string Tip_Lucrare { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lucrare> Lucrare { get; set; }
    }
}
