using System.ComponentModel.DataAnnotations;
using System;

namespace ContabilitatePrimaraPFA.Model
{
    public class Chitanta
    {
        public int ChitantaId { get; set; }
         [Required]
        public int NrChitanta { get; set; }
        [StringLength(3)][Required]
        public string Serie { get; set; }
        [Required]
        public DateTime? DataChitanta {get; set;}
    }
}