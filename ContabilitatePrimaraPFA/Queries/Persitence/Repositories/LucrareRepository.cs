using Queries.Core.Domain;
using Queries.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Queries.Persitence.Repositories
{
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
                         select new {l.LucrareId, a.StatusAccept,l.Nr_OCPI,l.DataInregistrare, l.TermenSolutionare,l.Nr_Proiect,l.AnProiect,t.TipLucrare1,
                         l.CadTop,l.UAT,r.StatusRec,b.Nume,b.Prenume};               
                return holder;
        }

        public IEnumerable<Lucrare> GetLucrareWithContract(int id)
        {
            return ContaContext.Lucrare.Where(s => s.ContractId == id).OrderBy(s => s.Nr_Proiect).ToList();
        }

        public IEnumerable<Lucrare> GetLucrariByType(int id)
        {
            return ContaContext.Lucrare.Where(s => s.TipLucrareId == id).OrderBy(s => s.Nr_Proiect).ToList();
        }

        public IEnumerable<Lucrare> GetLucrariByYear(DateTime year)
        {
            return ContaContext.Lucrare.Where(s => s.AnProiect == year.Year.ToString()).OrderBy(s => s.Nr_Proiect).ToList();
        }

        public IEnumerable<dynamic> GetLucrariForGridView(int year)
        {
            var holder = from l in ContaContext.Lucrare
                         join c in ContaContext.Contract on l.ContractId equals c.ContractId 
                         join a in ContaContext.AcceptataRefuzata on l.AcceptataRefuzataId equals a.AcceptataRefuzataId
                         join r in ContaContext.ReceptionatRespins on l.ReceptionatRespinsId equals r.ReceptionatRespinsId
                         join t in ContaContext.TipLucrare on l.TipLucrareId equals t.TipLucrareId
                         select new { l.LucrareId, a.StatusAccept, l.Nr_OCPI, l.DataInregistrare, l.TermenSolutionare, l.Nr_Proiect, l.AnProiect, l.AvizatorRegistrator, c.NrContract, t.TipLucrare1 , l.UAT, l.Observatii };
            return holder.ToList();
        }

        public ContaContext ContaContext
        { get { return Context as ContaContext; } }
    }
}
