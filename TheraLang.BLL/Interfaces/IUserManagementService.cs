using System;
using TheraLang.BLL.DataTransferObjects;
using System.Threading.Tasks;
using TheraLang.DAL.Entities;

namespace TheraLang.BLL.Interfaces
{
    public interface IUserManagementService
    {
        Task<User> GetUserById(Guid id);
        Task<User> GetUser(LoginModelDto loginModel);
    }
    
   
}
