using Queries.Core.Domain;
using System.Collections.Generic;
using System.Data;

namespace Queries.Core.Repositories
{
    public interface IBeneficiarRepository : IRepository<Beneficiar>
    {
        Beneficiar GetBeneficiarByCnp(string cnp);
    }
}
