using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
   public interface IController<TEntity> where TEntity : class
   {
       void Save(TEntity entity);
       void Edit(TEntity entity);
       void Delete(TEntity entity);
   }
}
