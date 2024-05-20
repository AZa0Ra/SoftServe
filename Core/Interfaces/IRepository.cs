using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class//, IBaseEntity
    {
        void Save();
        IEnumerable<TEntity> GetAll();

        TEntity GetByID(object id, params Expression<Func<TEntity, object>>[] includeProperties);
        IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");

        void Insert(TEntity entity);


        void Delete(TEntity entityToDelete);

        void Update(TEntity entityToUpdate);
    }
}
