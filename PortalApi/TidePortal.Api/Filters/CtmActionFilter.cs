using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TidePortal.Api.Options;
using TidePortal.Common.TokenHelper;

namespace TidePortal.Api.Filters
{
    public class CtmActionFilter:ActionFilterAttribute
    {
        public readonly ItemOptions _itemOptions;
        
        public CtmActionFilter(ItemOptions itemOptions) 
        {
            this._itemOptions = itemOptions;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var actionInfo = context.ActionDescriptor;
            if (context.ActionArguments.ContainsKey("token")) 
            {
                var tokenStr = context.ActionArguments["token"]?.ToString();
                var token = TokenHelper.UnlockToken(tokenStr);
                if (!token.isExp)
                {
                    context.HttpContext.Items[WebOptions.userId] = token.userId;
                    _itemOptions.Items[WebOptions.userId] = token.userId;
                }
                else 
                {
                    context.HttpContext.Response.StatusCode = 215;
                    var jsonResult = new JsonResult(new { isSuccess = "err", content = "timeExp" });
                    context.Result = jsonResult;
                }
            }
            else 
            {
                context.HttpContext.Response.StatusCode = 214;
                var jsonResult = new JsonResult(new { isSuccess = "err", content = "nonToken" });
                context.Result = jsonResult;
            }
        }
    }
}
