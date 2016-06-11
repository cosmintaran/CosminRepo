
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Queries.Core.Domain
{
    [Table("Plati")]
   public class Plata
    {
        public int PlataId { get; set; }
        [Required]
        public DateTime Data { get; set; }
        [Required]
        [StringLength(16)]
        public string TipDocument { get; set; }
        [Required]
        [StringLength(6)]
        public string Serie { get; set; }
        [Required]
        [Column("Numar Document")]
        public string Numar { get; set; }
        [Required]
        public decimal Suma { get; set; }
        [Required]
        public bool TransferBancar { get; set; }
        [Required]
        [Column("Plateste T.V.A")]
        public bool PlatitorTVA { get; set; }
        [Column("Valoare T.V.A.")]
        public decimal Tva { get; set; }
        [Column("Suma T.V.A.")]
        public decimal SumaTva { get; set; }
        public int? ContractId { get; set; }
        [Required]
        [StringLength(255)]
        [Column("Felul Operatiunii")]
        public string FelulOperatiunii { get; set; }

        public virtual Contract Contract { get; set; }

    }
}
