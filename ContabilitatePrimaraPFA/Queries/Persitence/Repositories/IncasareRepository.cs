
using Queries.Core.Domain;
using Queries.Core.Repositories;

namespace Queries.Persitence.Repositories
{
    public class IncasareRepository : Repository<Incasare>, IIncasareRepository
    {
        public IncasareRepository(ContaContext context)
            : base(context)
        {
            
        }
    }
}
