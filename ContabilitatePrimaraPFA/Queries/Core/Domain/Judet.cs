namespace Queries.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Judet")]
    public partial class Judet
    {
        public short JudetId { get; set; }

        [Column("Denumire Judet")]
        [Required]
        [StringLength(15)]
        public string Denumire_Judet { get; set; }
    }
}
