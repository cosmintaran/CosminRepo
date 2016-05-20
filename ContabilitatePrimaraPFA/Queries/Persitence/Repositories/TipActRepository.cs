using Queries.Core.Domain;
using Queries.Core.Repositories;

namespace Queries.Persitence.Repositories
{
   public class TipActRepository : Repository<TipAct>, ITipAct
    {
        public TipActRepository(ContaContext context)
            :base(context)
        { }


    }
}
