using System;
using System.Collections.Generic;
using Queries.Core.Domain;
using Queries.Core.Repositories;

namespace Queries.Persitence.Repositories
{
    public class AcceptatRespinsRepository : Repository<AcceptataRefuzata>, IAcceptatRespinsRepository
    {

        public AcceptatRespinsRepository(ContaContext context)
            :base(context)
        { }

        //ICollection<IAcceptatRespinsRepository> IAcceptatRespinsRepository.GetAll()
        //{
        //    return ICollection<AcceptataRefuzata> 
        //}
    }
}
