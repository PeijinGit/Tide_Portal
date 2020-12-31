using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TidePortal.Api.Options;
using TidePortal.Common.TokenHelper;
using TidePortal.Entity;
using TidePortal.Service;

namespace TidePortal.Api.Controllers
{
    [EnableCors("any")]
    public class BaseController : ControllerBase
    {
        protected readonly IAccountService _accountService;
        private readonly IConfiguration _configuration;

        public ItemOptions ItemOptions { get; }

        public BaseController(IAccountService accountService, IConfiguration configuration, ItemOptions itemOptions)
        {
            this._accountService = accountService;
            this._configuration = configuration;
            this.ItemOptions = itemOptions;
        }
        protected string CheckStatus(string qq, string pwd)
        {
            UserLoginResult userLoginResult = _accountService.ValidateLogin(qq, pwd);
            switch (userLoginResult)
            {
                case UserLoginResult.StopUse:
                    HttpContext.Response.StatusCode = 214;
                    return "用户已停用";
                case UserLoginResult.CustomerNoExist:
                    HttpContext.Response.StatusCode = 214;
                    return "用户不存在";
                case UserLoginResult.Deleted:
                    HttpContext.Response.StatusCode = 214;
                    return "用户已删除";
                case UserLoginResult.Successful:
                    var user = _accountService.GetUserByQQ(qq);
                    string res = TokenHelper.CreateToken(user.Id, Convert.ToInt32(_configuration["ExpTime"]));
                    return res;
                case UserLoginResult.WrongPassword:
                    HttpContext.Response.StatusCode = 214;
                    return "用户密码不正确";
                default:
                    HttpContext.Response.StatusCode = 214;
                    return "用户不存在";
            }
        }
    }
}
