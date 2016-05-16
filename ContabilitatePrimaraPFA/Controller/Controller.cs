namespace Controller
{
    using Queries.Persitence;
    using Queries.Core.Domain;

    public class ControllerLucrare : IController<Lucrare> 
    {
        //private ContaContext contaContext;
        //private UnitOfWork unityOfWork;

        public ControllerLucrare()
        {
        }

        public void Save(Lucrare entity)
        {
            ContaContext contaContext = new ContaContext();
            UnitOfWork unityOfWork = new UnitOfWork(contaContext);
            unityOfWork.Lucrari.Add(entity);
            unityOfWork.Complete();
            unityOfWork.Dispose();
            contaContext.Dispose();

        }

        public void Edit(Lucrare entity)
        {
            
        }

        public void Delete(Lucrare entity)
        {
            
        }
    }
}
