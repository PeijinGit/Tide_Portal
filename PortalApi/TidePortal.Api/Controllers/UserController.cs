using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TidePortal.Common.TokenHelper;
using TidePortal.Entity;
using TidePortal.Service;

namespace TidePortal.Api.Controllers
{
    [Route("[controller]/[action]")]
    //[ApiController]
    public class UserController : BaseController
    {
        public UserController(IAccountService accountService, IConfiguration configuration) : base(accountService, configuration)
        {
        }
        public Users GetUser(string token)
        {
            int userId = 3;
            if (!string.IsNullOrEmpty(token))
            {
                var tokenData = TokenHelper.UnlockToken(token);
                userId = tokenData.userId;
                var user = _accountService.GetUserById(userId);
                return user;
            }
            HttpContext.Response.StatusCode = 204;
            return default;
        }
    }
}
