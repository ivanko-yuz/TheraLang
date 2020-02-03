using System;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.DAL.Entities;

namespace TheraLang.BLL.Interfaces
{
    public interface IUserManagementService
    {
        User GetUser(LoginModelDto loginModel);
        User GetUserById (Guid id);
    }
    
   
}
