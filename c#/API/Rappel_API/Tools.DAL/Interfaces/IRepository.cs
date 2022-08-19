using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository<TId,TEntity> where TEntity : class, IEntity<TId>
    {
        TId Insert(TEntity entity);

        IEnumerable<TEntity> GetAll();

        TEntity GetById(TId id);

        bool Update(TId id ,TEntity entity);

        bool Delete(TId id);


    }
}
