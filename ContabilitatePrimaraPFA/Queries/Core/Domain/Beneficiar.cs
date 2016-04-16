using System.ComponentModel.DataAnnotations;
namespace ContabilitatePrimaraPFA.Model
{
    public class Beneficiar
    {
        public int BeneficiarId { get; private set; }
        [StringLength(50)] [Required]
        public string Nume { get; set; }

        [StringLength(50)] [Required]
        public string Prenume { get; set; }
        public string Adresa { get; set; }
        [Required]
        public string Buletin { get; set; }
        [Required]
        public int NrBuletin { get; set; }
        [Required]
        public int CNP { get; set; }

        private bool ValideazaCNP(int CNP)
        {
            return true;
        }
    }
}
