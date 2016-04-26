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

        public IEnumerable<Lucrare> GetLucrariForView(int year)
        {
            //var data = ContaContext.Lucrare.Where(x => x.An_Proiect == year.ToString())
            //                               .Select(x => new Lucrare
            //                               {
            //                                   //LucrareId = x.LucrareId,
            //                                   //AcceptataRefuzata = x.AcceptataRefuzata,
            //                                   An_Proiect = x.An_Proiect,
            //                                   //Beneficiar = x.Beneficiar,
            //                                  // Nr__Proiect = x.Nr__Proiect
            //                               }).ToList();
            //var data = ContaContext.Lucrare.SqlQuery("Select [Avizator_Registrator], [Nr. Proiect], [An Proiect] from Lucrare ").ToList();

            var data = (from p in ContaContext.Lucrare where p.An_Proiect == year.ToString() join a in ContaContext.AcceptataRefuzata on 
                       select new Lucrare { AcceptataRefuzata = p.AcceptataRefuzata, An_Proiect = p.An_Proiect,Avizator_Registrator = p.Avizator_Registrator}).ToList();

            return data; //TODO De terminat Query-ul
        }

        public ContaContext ContaContext
        { get { return Context as ContaContext; } }
    }
}
