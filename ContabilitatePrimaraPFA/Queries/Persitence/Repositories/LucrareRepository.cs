namespace Queries.Persitence.Repositories
{
    using Core.Domain;
    using Core.Repositories;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class LucrareRepository : Repository<Lucrare>, ILucrareRepository
    {

        public LucrareRepository(ContaContext context)
            :base(context)
        {

        }

        public IEnumerable<dynamic> GetLucrariByBeneficiarName(string name)
        {
            var holder = from l in ContaContext.Lucrare
                         join c in ContaContext.Contract on l.ContractId equals c.ContractId
                         join b in ContaContext.Beneficiar on c.BeneficiarId equals b.BeneficiarId
                         join a in ContaContext.AcceptataRefuzata on l.AcceptataRefuzataId equals a.AcceptataRefuzataId
                         join r in ContaContext.ReceptionatRespins on l.ReceptionatRespinsId equals r.ReceptionatRespinsId
                         join t in ContaContext.TipLucrare on l.TipLucrareId equals t.TipLucrareId
                         where b.CNP == name
                         select new {l.LucrareId, a.StatusAccept,l.Nr_OCPI,l.DataInregistrare, l.TermenSolutionare,Nr_Proiect = l.NrProiect,l.AnProiect,TipLucrare1 = t.Tip_Lucrare,
                         l.CadTop,l.UAT,r.StatusRec,b.Nume,b.Prenume};               
                return holder;
        }

        public IEnumerable<Lucrare> GetLucrareByContract(int id)
        {
            return ContaContext.Lucrare.Where(s => s.ContractId == id).OrderBy(s => s.NrProiect).ToList();
        }

        public IEnumerable<Lucrare> GetLucrariByType(int id)
        {
            return ContaContext.Lucrare.Where(s => s.TipLucrareId == id).OrderBy(s => s.NrProiect).ToList();
        }

        public IEnumerable<dynamic> GetLucrariByYear(string year)
        {
           
               var  holder = (from l in ContaContext.Lucrare
                    join c in ContaContext.Contract on l.ContractId equals c.ContractId
                    join a in ContaContext.AcceptataRefuzata on l.AcceptataRefuzataId equals a.AcceptataRefuzataId
                    join r in ContaContext.ReceptionatRespins on l.ReceptionatRespinsId equals r.ReceptionatRespinsId
                    join t in ContaContext.TipLucrare on l.TipLucrareId equals t.TipLucrareId
                    join b in ContaContext.Beneficiar on c.BeneficiarId equals b.BeneficiarId
                    where l.AnProiect == year
                    select new{l.LucrareId,a.StatusAccept, l.Nr_OCPI, l.DataInregistrare, l.TermenSolutionare,l.AvizatorRegistrator,
                        TipLucrare = t.Tip_Lucrare,l.NrProiect, l.AnProiect,b.Nume,b.Prenume, l.CadTop,l.UAT,c.NrContract, c.Data.Year, l.Observatii, r.StatusRec}).ToList();

                var retVal = from h in holder
                             select new{h.LucrareId, AceptataRefuzata = String.Format(h.StatusAccept),NrInregOCPI = String.Format("{0}{1}{2}",h.Nr_OCPI, @"-",h.DataInregistrare.Value.ToShortDateString()), h.TermenSolutionare,
                                        h.AvizatorRegistrator, h.TipLucrare, NrProiect = String.Format("{0}{1}{2}", h.NrProiect, @"/", h.AnProiect),
                                        Beneficiari = String.Format("{0} {1}", h.Nume, h.Prenume), h.CadTop, h.UAT, Contracte= String.Format("{0}{1}{2}", h.NrContract,@"/", h.Year),
                                        ReceptionataRespinsa = String.Format(h.StatusRec), h.Observatii}; 
                     
                return retVal;
        }

        public ContaContext ContaContext => Context as ContaContext;
    }
}
