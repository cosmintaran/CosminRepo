using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Queries.Core.Domain;
using Queries.Core.Repositories;

namespace Queries.Persitence.Repositories
{
   public class PlataRepository : Repository<Plata>, IPlataRepository
    {
        public PlataRepository(ContaContext context)
            :base(context)
        { }
    }
}
