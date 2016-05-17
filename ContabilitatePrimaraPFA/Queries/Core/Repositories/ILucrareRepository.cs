using Queries.Core.Domain;
using System;
using System.Collections.Generic;

namespace Queries.Core.Repositories
{
    public interface ILucrareRepository : IRepository<Lucrare>
    {
        IEnumerable<Lucrare> GetLucrariByNumberAndYear(string number, DateTime year);

        IEnumerable<dynamic> GetLucrareByContract(string nrContract);
        IEnumerable<dynamic> GetLucrariByBeneficiarName(string name);
        IEnumerable<dynamic> GetLucrariByCodLucrare(string codLucrare);
        IEnumerable<dynamic> GetLucrariByYear(string year);
        IEnumerable<dynamic> GetLucrariByUat(string uat);
        IEnumerable<dynamic> GetLucrariByCnp(string cnp);
        IEnumerable<dynamic> GetLucrariByStatusOcpi(string status);
        IEnumerable<dynamic> GetLucrariByNrDocumentatie(string nrDoc);
        IEnumerable<dynamic> GetLucrari();
    }
}
