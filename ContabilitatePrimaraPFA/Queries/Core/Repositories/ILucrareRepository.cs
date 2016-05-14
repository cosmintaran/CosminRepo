using Queries.Core.Domain;
using System;
using System.Collections.Generic;

namespace Queries.Core.Repositories
{
    public interface ILucrareRepository : IRepository<Lucrare>
    {
        IEnumerable<Lucrare> GetLucrareWithContract(int id);
        IEnumerable<dynamic> GetLucrariByBeneficiarName(string cnp);
        IEnumerable<Lucrare> GetLucrariByYear(DateTime year);
        IEnumerable<Lucrare> GetLucrariByType(int type);
        IEnumerable<dynamic> GetLucrariForGridView(int year); 
    }
}
