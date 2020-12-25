using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TidePortal.Entity;

namespace TidePortal.Core
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly ZhaoxiPortalContext _context;
        //依赖注入
        public Repository(ZhaoxiPortalContext context)
        {
            this._context = context;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> ListAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> ListByCustom(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> ListById(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
