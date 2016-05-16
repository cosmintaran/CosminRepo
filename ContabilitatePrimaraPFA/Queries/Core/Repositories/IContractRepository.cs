using System.Collections;
using Queries.Core.Domain;
using System.Collections.Generic;

namespace Queries.Core.Repositories
{
    public interface IContractRepository : IRepository<Contract>
    {

        IEnumerable<Contract> GetContractByYear(int year);
        IEnumerable<dynamic> GetContractByNumber(string nrContract);
        IEnumerable<dynamic> GetContractByBeneficiar(string name);
        IEnumerable<dynamic> GetContractByAmount(decimal val);
        IEnumerable<dynamic> GetGridViewContractByYear(int year);
    }
}
