using Queries.Core.Domain;
using Queries.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Queries.Persitence.Repositories
{
    public class BeneficiarRepository : Repository<Beneficiar> ,IBeneficiarRepository
    {


        public BeneficiarRepository(ContaContext context)
            :base(context)
        {

        }

        public Beneficiar GetBeneficiarByCNP(int id)
        {
           return ContaContext.Beneficiari.Where(s => s.CNP == id) as Beneficiar;
        }

        public ContaContext ContaContext
        {
            get { return Context as ContaContext; }
        }
    }
}
