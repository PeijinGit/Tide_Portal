﻿using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TidePortal.Api.Options;
using TidePortal.Common.MemoryHelper;
using TidePortal.Common.ValidateCode;
using TidePortal.Entity;
using TidePortal.Service;
using TidePortal.Service.Dto;

namespace TidePortal.Api.Controllers
{
    public class MyUser 
    {
        public int QQ { get; set; }
        public string NickName { get; set; }
    }

    [Route("[controller]/[action]")]
    //[ApiController]
    public class LoginController : BaseController
    {
        public LoginController(IAccountService accountService, IConfiguration configuration, ItemOptions itemOptions) : base(accountService, configuration, itemOptions)
        {
        }

        public string CheckLogin(string qq, string pwd, string validateString)
        {
            string ip = HttpContext.Connection.RemoteIpAddress.ToString();
            //MemoryCacheHelper.SetCache(ip, "test");
            string validate = MemoryCacheHelper.GetCache(ip).ToString();
            if (validate != null && validateString.ToLower() == validate.ToLower())
            {
                return CheckStatus(qq, pwd);
            }
            else
            {
                HttpContext.Response.StatusCode = 214;
                return "验证码错误";
            }
        }

        //[HttpPost]
        public string AddUserTest(MyUser userInputDto) 
        {
            Console.WriteLine(userInputDto);
            return "OK";
        }

        public void AddUserTestt(int qq, string name)
        {
            Console.WriteLine(qq + name);
        }

        public string AddUser(UserInputDto userInputDto) 
        {
            userInputDto.RegDate = DateTime.Now;
            userInputDto.CreateTime = DateTime.Now;
            userInputDto.LoginNum = 0;
            string ip = HttpContext.Connection.RemoteIpAddress.ToString();
            string validateCode = MemoryCacheHelper.GetCache(ip).ToString();
            //if (!string.IsNullOrEmpty(validateCode) && validateCode.ToLower() == userInputDto.validateCode) 
            //{
                Users user;
                user = _accountService.GetUserByQQ(userInputDto.QQ);
                if (user != null)
                {
                    HttpContext.Response.StatusCode = 214;
                    return "hasQQ";
                }
                int row = _accountService.CreateAndUpdateUsers(userInputDto);
                if (row >= 1) return "success";
                else
                {
                    HttpContext.Response.StatusCode = 214;
                    return "UnknowErr";
                }
            //}
            //else
            //{
            //    HttpContext.Response.StatusCode = 214;
            //    return "ValidateErr";
            //}
        }

        public IActionResult GetValidateCode()
        {
            string validateString = ValidateCodeHelper.CreateVaildateString(4);
            byte[] buffer = ValidateCodeHelper.CreateValidateCode(validateString);
            string ip = HttpContext.Connection.RemoteIpAddress.ToString();
            MemoryCacheHelper.SetCache(ip, validateString);
            return File(buffer, @"image/png");
        }

        /// <summary>
        /// 用于图片上传和下载，可以先不看，使用时再看视频
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        [HttpPost]
        public string GetFile(List<IFormFile> img)
        {
            //var files =  Request.Form.Files;
            if (img.Count < 1)
            {
                return "文件为空";
            }
            var now = DateTime.Now;
            //获取当前的Web目录
            var currFilePath = Path.Combine("update/");
            //获取根目录
            var webRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", currFilePath);
            //判断目类是否存在
            if (!Directory.Exists(webRootPath))
            {
                Directory.CreateDirectory(webRootPath);
            }

            foreach (var item in img)
            {
                if (item != null)
                {
                    //文件后缀
                    var fileExt = Path.GetExtension(item.FileName);
                    //判断后缀是否是图片
                    const string fileFilt = ".gif|.jpg|.jpeg|.png";
                    if (fileExt == null)
                    {
                        break;
                    }
                    //var fileFilts = fileFilt.Split('|');
                    //if(fileFilts.Contains(fileExt.ToLower()))
                    if (fileFilt.IndexOf(fileExt.ToLower(), StringComparison.Ordinal) <= -1)
                    {
                        break;
                    }
                    //判断文件大小
                    long length = item.Length;
                    if (length > 2048 * 1000)
                    {
                        break;
                    }
                    var saveName = DateTime.Now.ToString("yyyyMMddHHmmssfff") + fileExt;
                    using (FileStream fs = System.IO.File.Create(webRootPath + saveName))
                    {
                        item.CopyTo(fs);
                        fs.Flush();
                    }
                }
            }
            return "OK";
        }

        /// Startup function
        public string StartUpText() 
        {
            return "Welcome!!!";
        }

    }
}