using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TidePortal.Entity;

namespace TidePortal.Service
{
    public partial class AccountService
    {
        public IQueryable<Resources> ListResourceAll()
        {
            return _resourcesRepository.ListAll();
        }
        public Resources ListResourceById(int id)
        {
            return _resourcesRepository.ListById(id).FirstOrDefault();
        }
        public IQueryable<Resources> ListResourcesByIds(IEnumerable<int> ids)
        {
            return _resourcesRepository.ListAll().Where(m => ids.Contains(m.Id));
        }
        public IQueryable<Resources> ListResourcesByUserId(int id)
        {
            var ids = GetResourceIdsByUserId(id);
            return _resourcesRepository.ListAll().Where(m => ids.Contains(m.Id));
        }
    }
}
