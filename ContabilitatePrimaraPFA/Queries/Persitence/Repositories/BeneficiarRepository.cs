using System.Collections.Generic;
using System.Data;
using Queries.Core.Domain;
using Queries.Core.Repositories;
using System.Linq;


namespace Queries.Persitence.Repositories
{
    public class BeneficiarRepository : Repository<Beneficiar> ,IBeneficiarRepository
    {


        public BeneficiarRepository(ContaContext context)
            :base(context)
        {

        }

        public Beneficiar GetBeneficiarByCnp(string cnp)
        {
           return (Beneficiar) ContaContext.Beneficiar.Where(s => s.CNP == cnp) ;
        }

        public ContaContext ContaContext => Context as ContaContext;
    }
}
