using Queries.Core.Domain;
using System.Collections.Generic;

namespace Queries.Core.Repositories
{
    public interface IBeneficiarRepository : IRepository<Beneficiar>
    {
        Beneficiar GetBeneficiarByCNP(int id);
    }
}
