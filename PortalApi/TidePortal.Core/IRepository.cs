using System;
using System.Linq;
using System.Linq.Expressions;
using TidePortal.Entity;

namespace TidePortal.Core
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> ListAll();
        IQueryable<TEntity> ListById(int id);
        IQueryable<TEntity> ListByCustom(Expression<Func<TEntity, bool>> filter);
        int Insert(TEntity entity);
        int Update(TEntity entity);
        void Delete(int id);
    }
}
