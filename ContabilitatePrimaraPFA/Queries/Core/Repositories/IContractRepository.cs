using Queries.Core.Domain;
using System.Collections.Generic;

namespace Queries.Core.Repositories
{
    public interface IContractRepository : IRepository<Contract>
    {

        IEnumerable<Contract> GetContractsByYear(int year);
        IEnumerable<Contract> GetContractsByNumber(string nrContract);
        Contract GetContract(int year, string nrContract);
    }
}
