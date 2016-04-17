namespace Queries.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Lucrare
    {
        [Key]
        public int LucrareId               { get; private set; }     
        public string NrInregOCPI          { get; set; }
        public DateTime? DataInregistrare  { get; set; }
        public DateTime? TermenSolutionare { get; set; }
        public string AvizatorRegistrator  { get; set; }
        public byte TipLucrareId           { get; set; }
        public int Nrproiect               { get; set; }
        public DateTime? AnProiect         { get; set; }
        public string Cadastral            { get; set; }
        public string UAT                  { get; set; }
        public string Observatii           { get; set; }
        public int BeneficiarId            { get; set; }
        public byte AcceptataRespinsaId    { get; set; }
        public int ContractId              { get; set; }
        public byte ReceptionatRespinsId   { get; set; }
             
        public virtual ICollection<Beneficiar> Beneficiar { get; set; }
        public virtual AcceptatRespins AcceptRespins{ get; set; }
        public virtual Contract Contract   { get; set; }
        public virtual ReceptionatRespins  ReceptionatRespins{ get; set; }
        public virtual TipLucrare TipLucrari { get; set; }
       
    }
}
