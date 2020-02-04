using System;
using System.Threading.Tasks;
using TheraLang.DAL.Entities;

namespace TheraLang.BLL.Interfaces
{
    public interface IUserManagementService
    {
        Task<User> GetUser(string userName, string password);
        Task<User> GetUserById(Guid id);
    }
    
   
}
