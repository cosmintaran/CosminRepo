using Queries.Core.Domain;
using System;
using System.Collections.Generic;

namespace Queries.Core.Repositories
{
    public interface ILucrareRepository : IRepository<Lucrare>
    {
        IEnumerable<Lucrare> GetLucrareByContract(int id);
        IEnumerable<dynamic> GetLucrariByBeneficiarName(string cnp);
        IEnumerable<Lucrare> GetLucrariByType(int type);
        IEnumerable<dynamic> GetLucrariByYear(string year); 
    }
}
