using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TidePortal.Common;

namespace TidePortal.Api.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public IActionResult GetValidateCode()
        {
            string validateString = CreateVaildateString(4);
            byte[] buffer = CreateValidateCode(validateString);
            string ip = HttpContext.Connection.RemoteIpAddress.ToString();
            
            MemoryCacheHelper.SetCache(ip, validateString);
            return File(buffer, @"image/png");
        }
        private static string CreateVaildateString(int len)
        {
            //设置允许出现的字符
            string chars = "abcdefghijklmnopqrstuvwxyz23456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //通过随机数生成验证码
            Random random = new Random();
            string validateString = "";
            for (int i = 0; i < len; i++)
            {
                validateString += chars[random.Next(chars.Length)];
            }
            return validateString;
        }

        private byte[] CreateValidateCode(string validateCode)
        {
            /*
            **  创建画板并画画的过程 
            */
            //创建画布
            Bitmap bitmap = new Bitmap(validateCode.Length * 24, 30);
            //创建画笔
            Graphics graphics = Graphics.FromImage(bitmap);
            //给画布涂上背景色
            graphics.Clear(Color.White);
            //设置颜料板和调色刷
            RectangleF rf = new RectangleF(0, 0, bitmap.Width, bitmap.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rf, Color.Red, Color.DarkBlue, 1.2f, true);
            //设置需要画到图中文字的格式（字体，大小，是否加粗，斜体）
            Font font = new Font("Consolas", 16, FontStyle.Bold | FontStyle.Italic);
            //将字画到画板中
            graphics.DrawString(validateCode, font, brush, 0, 0);

            /*
            **  存储验证码并返回的过程
            */
            //创建一个可以用于保存图片的缓冲区
            MemoryStream memoryStream = new MemoryStream();
            //将图片存到缓冲区中
            bitmap.Save(memoryStream, ImageFormat.Jpeg);
            //释放画板
            bitmap.Dispose();
            //返回byte[]
            return memoryStream.ToArray();
            //bitmap.Save(AppDomain.CurrentDomain.BaseDirectory + "aaa.jpg");
        }

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
    }
}