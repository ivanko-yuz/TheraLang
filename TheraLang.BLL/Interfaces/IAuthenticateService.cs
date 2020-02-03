using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.DAL.Entities;

namespace TheraLang.BLL.Interfaces
{
    public interface IAuthenticateService
    {
        bool IsAuthenticated(out string token, User user);
        Task<AuthUser> GetAuthUserAsync();
    }
}
