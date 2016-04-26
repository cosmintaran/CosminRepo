using Queries.Core;
using Queries.Core.Repositories;
using Queries.Persitence.Repositories;

namespace Queries.Persitence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ContaContext m_context;

        public UnitOfWork (ContaContext context)
        {
            m_context = context;
            Lucrari = new LucrareRepository(m_context);
            Beneficiari = new BeneficiarRepository(m_context);
            AcceptateRespinse = new AcceptatRefuzataRepository(m_context);
            TipLucrare = new TipLucrareRepository(m_context);
            ReceptionateRespinse = new ReceprionataRespinsaRepository(m_context);
            Contracte = new ContractRepository(m_context);
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
            return m_context.SaveChanges();
        }

        public void Dispose()
        {
            m_context.Dispose();
        }
    }
}
