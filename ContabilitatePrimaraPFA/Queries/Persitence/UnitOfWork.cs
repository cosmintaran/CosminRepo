using System;

namespace Queries.Persitence
{
    using Queries.Core;
    using Queries.Core.Repositories;
    using Queries.Persitence.Repositories;

    public sealed class UnitOfWork : IUnitOfWork
    {
        private ContaContext _mContext;

        public UnitOfWork (ContaContext context)
        {
            _mContext = context;
            Lucrari = new LucrareRepository(_mContext);
            Beneficiari = new BeneficiarRepository(_mContext);
            AcceptateRespinse = new AcceptatRefuzataRepository(_mContext);
            TipLucrare = new TipLucrareRepository(_mContext);
            ReceptionateRespinse = new ReceprionataRespinsaRepository(_mContext);
            Contracte = new ContractRepository(_mContext);
        }

        #region Propertys

        public IBeneficiarRepository Beneficiari { get; set; }

        public IChitantaRepository Chitante { get; set; }

        public IContractRepository Contracte { get; set; }

        public IFacturaRepository Facturi { get; set; }

        public ILucrareRepository Lucrari { get; set; }

        public IAcceptatRefuzataRepository AcceptateRespinse { get; set; }

        public ITipLucrareRepository TipLucrare { get; set; }

        public IReceptionatRespinsRepository ReceptionateRespinse { get; set; }

        #endregion //end of Properties

        public int Complete()
        {
            return _mContext.SaveChanges();
        }

        public void Dispose()
        {
            _mContext.Dispose();
        }
    }
}
