using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository<TKey, TEntity> where TEntity : IModel<TKey>
    {
        TKey Add(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(TKey id);
        bool Update(TEntity entity);
        bool Delete(TKey id);
    }
}
