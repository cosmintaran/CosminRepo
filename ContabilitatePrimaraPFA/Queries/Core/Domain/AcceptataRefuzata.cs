namespace Queries.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AcceptataRefuzata")]
    public partial class AcceptataRefuzata
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AcceptataRefuzata()
        {
            Lucrare = new HashSet<Lucrare>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte AcceptataRefuzataId { get; set; }

        [Required]
        [StringLength(10)]
        public string Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lucrare> Lucrare { get; set; }
    }
}
