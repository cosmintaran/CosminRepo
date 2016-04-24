using Queries.Core.Domain;
using Queries.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Queries.Persitence.Repositories
{
    public class LucrareRepository : Repository<Lucrare>, ILucrareRepository
    {

        public LucrareRepository(ContaContext context)
            :base(context)
        {

        }

        public IEnumerable<Lucrare> GetLucrareWithBeneficiar(int id)
        {
            return ContaContext.Lucrare.Where(s => s.BeneficiarId== id).OrderBy(s => s.Nr__Proiect).ToList();
        }

        public IEnumerable<Lucrare> GetLucrareWithContract(int id)
        {
            return ContaContext.Lucrare.Where(s => s.ContractId == id).OrderBy( s => s.Nr__Proiect).ToList();
        }

        public IEnumerable<Lucrare> GetLucrariByType(int id)
        {
            return ContaContext.Lucrare.Where(s => s.TipLucrareId == id).OrderBy(s => s.Nr__Proiect).ToList();
        }

        public IEnumerable<Lucrare> GetLucrariByYear(DateTime year)
        {
            return ContaContext.Lucrare.Where(s => s.An_Proiect == year.Year.ToString()).OrderBy(s => s.Nr__Proiect).ToList();
        }

        public ContaContext ContaContext
        { get { return Context as ContaContext; } }
    }
}
