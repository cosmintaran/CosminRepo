using Queries.Core.Domain;
using Queries.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries.Persitence.Repositories
{
   public class ContractRepository : Repository<Contract>, IContractRepository
    {
       public ContractRepository(ContaContext context)
           :base(context)
       { }

       public IEnumerable<Contract> GetContractsByYear(int year)
       {
           return ContaContext.Contract.Where(s => s.Data.Year == year).ToList(); 
       }

       public IEnumerable<Contract> GetContractsByNumber(string nrContract)
       {
           return ContaContext.Contract.Where(s => s.NrContract == nrContract).ToList();
       }

       public Contract GetContract(int year, string nrContract)
       {            
           return (Contract)ContaContext.Contract.Where(s => s.Data.Year == year).Select(x=>x.NrContract == nrContract);
       }

       public ContaContext ContaContext
       { get { return Context as ContaContext; } }
    }
}
