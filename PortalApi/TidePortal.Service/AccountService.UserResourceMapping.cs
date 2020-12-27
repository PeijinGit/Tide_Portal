using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TidePortal.Service
{
    public partial class AccountService
    {
        public IQueryable<int> GetResourceIdsByUserId(int userId)
        {
            var resources = _userResourceMappingRepository.ListByCustom(m => m.UserId == userId);
            var resourceIds = resources.Select(m => m.ResourceId);
            return resourceIds;
        }
    }
}
