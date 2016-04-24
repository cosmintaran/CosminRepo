using Queries.Core.Repositories;
using System;

namespace Queries.Core
{
   public interface IUnitOfWork : IDisposable
    {
        ILucrareRepository Lucrari        { get; }
        IContractRepository Contracte     { get; }
        IFacturaRepository Facturi        { get; }
        IChitantaRepository Chitante      { get; }
        IBeneficiarRepository Beneficiari { get; }
        IAcceptatRespinsRepository AcceptateRespinse { get; }
        ITipLucrareRepository TipLucrare { get; }
        int Complete();
    }
}
