using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TidePortal.Entity;
using TidePortal.Service;

namespace TidePortal.Api.Controllers
{
    [EnableCors("any")]
    public class BaseController : ControllerBase
    {
        protected readonly IAccountService _accountService;
        public BaseController(IAccountService accountService)
        {
            this._accountService = accountService;
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
                    return "success";
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
