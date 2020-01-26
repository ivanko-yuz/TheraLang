using System;
using System.Collections.Generic;
using System.Text;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.Interfaces
{
    public interface IAuthenticateService
    {
        bool IsAuthenticated(LoginModelDto request, out string token);
    }
}
