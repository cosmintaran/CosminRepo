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
        public long LucrareId { get; set; }

        public byte AcceptataRefuzataId { get; set; }

        public int Nr_OCPI { get; set; }

        [Column(TypeName = "date")]
        public DateTime Data_inregistrare { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Termen_Solutionare { get; set; }

        [Column(TypeName = "text")]
        public string Avizator_Registrator { get; set; }

        public int? TipLucrareId { get; set; }

        [Column("Nr. Proiect")]
        [Required]
        [StringLength(4)]
        public string Nr__Proiect { get; set; }

        [Column("An Proiect")]
        [Required]
        [StringLength(4)]
        public string An_Proiect { get; set; }

        public long? ContractId { get; set; }

        [Required]
        [StringLength(100)]
        public string UAT { get; set; }

        [Column("Receptionat/Respins")]
        public byte? Receptionat_Respins { get; set; }

        public long? BeneficiarId { get; set; }

        public virtual AcceptataRefuzata AcceptataRefuzata { get; set; }

        public virtual Beneficiar Beneficiar { get; set; }

        public virtual Contract Contract { get; set; }

        public virtual ReceptionatRespins ReceptionatRespins { get; set; }

        public virtual TipLucrare TipLucrare { get; set; }
    }
}
