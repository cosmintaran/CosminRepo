using System;
using System.Collections.Generic;

namespace ContabilitatePrimaraPFA.Model
{
    public class Contract
    {
        public int ContractId { get; private set; }
        public int NrContract { get; set; }
        public DateTime? DataContract { get; set; }
        public int BeneficiarId { get; set; }
        public string ScopContract { get; set; }
        public Decimal ValoareContract { get; set; }
        public int ChitantaId { get; set; }
        public int FacturaId { get; set; }
        public string Observatii { get; set; }

        public virtual ICollection<Beneficiar> Beneficiari { get; set;}
        public virtual ICollection<Chitanta> Chitante { get; set; }
        public virtual ICollection<Factura> Facturi { get; set; }
    }
}
