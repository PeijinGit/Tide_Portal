using System;
using System.Collections.Generic;
using System.Text;

namespace TidePortal.Entity
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
