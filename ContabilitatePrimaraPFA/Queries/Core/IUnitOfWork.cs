﻿using Queries.Core.Repositories;
using System;

namespace Queries.Core
{
   public interface IUnitOfWork : IDisposable
    {
        ILucrareRepository Lucrari        { get; }
        IContractRepository Contracte     { get; }
        IIncasareRepository Incasari        { get; }
        IPlataRepository Plati      { get; }
        IBeneficiarRepository Beneficiari { get; }
        IAcceptatRefuzataRepository AcceptateRespinse { get; }
        ITipLucrareRepository TipLucrare { get; }
        IReceptionatRespinsRepository ReceptionateRespinse { get; }
        ITipAct TipActe { get; }
        int Complete();
    }
}
