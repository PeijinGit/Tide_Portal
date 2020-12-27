using System;
using System.Collections.Generic;
using System.Text;

namespace TidePortal.Service.Dto
{
    public enum UserLoginResult
    {
        StopUse,
        CustomerNoExist,
        Deleted,
        Successful,
        WrongPassword,
    }
}
