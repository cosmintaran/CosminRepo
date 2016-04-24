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
            AcceptateRespinse = new AcceptatRespinsRepository(m_context);
            TipLucrare = new TipLucrareRepository(m_context);
        }

        #region Propertys
        public IBeneficiarRepository Beneficiari { get;}

        public IChitantaRepository Chitante { get; }
  

        public IContractRepository Contracte { get; }


        public IFacturaRepository Facturi { get; }


        public ILucrareRepository Lucrari { get; }

        public IAcceptatRespinsRepository AcceptateRespinse { get; }
        public ITipLucrareRepository TipLucrare { get; }

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
