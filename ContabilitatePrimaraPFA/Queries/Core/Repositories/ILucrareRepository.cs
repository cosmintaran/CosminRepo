using Queries.Core.Domain;
using System;
using System.Collections.Generic;

namespace Queries.Core.Repositories
{
    public interface ILucrareRepository : IRepository<Lucrare>
    {
        IEnumerable<Lucrare> GetLucrareWithContract(int id);
        IEnumerable<Lucrare> GetLucrareWithBeneficiar(int id);
        IEnumerable<Lucrare> GetLucrariByYear(DateTime year);
        IEnumerable<Lucrare> GetLucrariByType(int type);
    }
}
