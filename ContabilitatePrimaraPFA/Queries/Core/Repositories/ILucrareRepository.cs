using Queries.Core.Domain;
using System;
using System.Collections.Generic;

namespace Queries.Core.Repositories
{
    public interface ILucrareRepository : IRepository<Lucrare>
    {
        IEnumerable<dynamic> GetLucrareByContract(string nrContract);
        IEnumerable<dynamic> GetLucrariByBeneficiarName(string name);
        IEnumerable<dynamic> GetLucrariByCodLucrare(string codLucrare);
        IEnumerable<dynamic> GetLucrariByYear(string year);
        IEnumerable<dynamic> GetLucrariByUat(string uat);
        IEnumerable<dynamic> GetLucrariByCNP(string cnp);
        IEnumerable<dynamic> GetLucrariByStatusOCPI(string status);
        IEnumerable<dynamic> GetLucrariByNrDocumentatie(string nrDoc);
    }
}
