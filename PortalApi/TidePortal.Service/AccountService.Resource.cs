﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TidePortal.Entity;
using TidePortal.Service.Dto;

namespace TidePortal.Service
{
    public partial class AccountService
    {
        public List<ResourceByListDto> ListResourceAll()
        {
            var res = _resourcesRepository.ListAll();
            List<ResourceByListDto> list = new List<ResourceByListDto>();
            foreach (var item in res)
            {
                list.Add(ResourceByListDto.ToDto(item));
            }

            return list;
        }

        public ResourceDto ListResourceById(int id)
        {
            return ResourceDto.ToDto(_resourcesRepository.ListById(id).FirstOrDefault());
        }

        public List<ResourceByListDto> ListResourcesByIds(IEnumerable<int> ids)
        {
            var res = _resourcesRepository.ListAll().Where(m => ids.Contains(m.Id));
            List<ResourceByListDto> list = new List<ResourceByListDto>();
            foreach (var item in res)
            {
                list.Add(ResourceByListDto.ToDto(item));
            }
            return list;
        }

        public List<ResourceByListDto> ListResourcesByUserId(int id)
        {
            var ids = GetResourceIdsByUserId(id);
            var res = _resourcesRepository.ListAll().Where(m => ids.Contains(m.Id));
            List<ResourceByListDto> list = new List<ResourceByListDto>();
            foreach (var item in res)
            {
                list.Add(ResourceByListDto.ToDto(item));
            }
            return list;
        }
    }
}
