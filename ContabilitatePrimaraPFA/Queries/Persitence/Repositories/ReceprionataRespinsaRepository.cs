﻿using Queries.Core.Domain;
using Queries.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries.Persitence.Repositories
{
   public class ReceprionataRespinsaRepository: Repository<ReceptionatRespins>, IReceptionatRespinsRepository
    {
        public ReceprionataRespinsaRepository(ContaContext context)
            :base(context)
       { }
    }
}
