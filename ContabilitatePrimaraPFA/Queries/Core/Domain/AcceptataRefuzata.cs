namespace Queries.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("AcceptataRefuzata")]
    public partial class AcceptataRefuzata
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AcceptataRefuzata()
        {
            Lucrare = new HashSet<Lucrare>();
        }

        public int AcceptataRefuzataId { get; set; }

        [Required]
        [StringLength(10)]
        public string StatusAccept { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lucrare> Lucrare { get; set; }
    }
}
