using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TidePortal.Entity;
using TidePortal.Service.Dto;

namespace TidePortal.Service
{
    public interface IAccountService
    {
        IQueryable<Users> ListUserAll();
        Users GetUserById(int id);
        Users GetUserByQQ(string qq);
        int CreateAndUpdateUsers(UserInputDto userInputDto);
        void DeleteUser(int id);
        UserLoginResult ValidateLogin(string qq, string password);
        IQueryable<int> GetResourceIdsByUserId(int userId);
        IQueryable<Resources> ListResourceAll();
        Resources ListResourceById(int id);
        IQueryable<Resources> ListResourcesByIds(IEnumerable<int> ids);
        IQueryable<Resources> ListResourcesByUserId(int id);

    }
}
