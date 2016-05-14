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

        public Beneficiar GetBeneficiarByCNP(string cnp)
        {
           return ContaContext.Beneficiar.Where(s => s.CNP == cnp) as Beneficiar;
        }

        public ContaContext ContaContext
        {
            get { return Context as ContaContext; }
        }
    }
}
