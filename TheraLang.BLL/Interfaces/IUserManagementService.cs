using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheraLang.DAL.Entities;

namespace TheraLang.BLL.Interfaces
{
    public interface IUserManagementService
    {
        Task<User> GetUserAsync(string userName, string password);
        Task<User> GetUserByIdAsync(Guid id);
    }
    
   
}
