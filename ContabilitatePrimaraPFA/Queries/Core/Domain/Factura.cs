using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ContabilitatePrimaraPFA.Model
{
    public class Factura
    {
        public int FacturaId { get; private set; }
        [Required]
        public int NrFactura { get; set; }
        [Required] [StringLength(3)]
        public string SerieFactura { get; set; }
        public DateTime DataFacturare { get; set; }
        public int ChitantaId { get; set; }

        public virtual ICollection<Chitanta> Chitante { get; set; }
    }
}