namespace Queries.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lucrare")]
    public partial class Lucrare
    {
        public int LucrareId { get; set; }

        public int AcceptataRefuzataId { get; set; }

        [Column("Nr.OCPI")]
        [StringLength(10)]
        public string Nr_OCPI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataInregistrare { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TermenSolutionare { get; set; }

        [Column(TypeName = "text")]
        public string AvizatorRegistrator { get; set; }

        public int? TipLucrareId { get; set; }

        [Column("Nr.Proiect")]
        [Required]
        [StringLength(6)]
        public string NrProiect { get; set; }

        [Required]
        [StringLength(4)]
        public string AnProiect { get; set; }

        public int? ContractId { get; set; }

        [Column("Cad/Top", TypeName = "text")]
        [Required]
        public string CadTop { get; set; }

        [Required]
        [StringLength(100)]
        public string UAT { get; set; }

        [Column(TypeName = "text")]
        public string Observatii { get; set; }

        public int ReceptionatRespinsId { get; set; }

        public virtual AcceptataRefuzata AcceptataRefuzata { get; set; }

        public virtual Contract Contract { get; set; }

        public virtual ReceptionatRespins ReceptionatRespins { get; set; }

        public virtual TipLucrare TipLucrare { get; set; }
    }
}
