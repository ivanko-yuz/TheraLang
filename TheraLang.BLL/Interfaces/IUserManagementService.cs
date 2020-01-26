using System;
using System.Collections.Generic;
using System.Text;
using TheraLang.DAL.Entities;

namespace TheraLang.BLL.Interfaces
{
    public interface IUserManagementService
    {
        User GetUser(string username, string password);
        User GetUserById (Guid id);
    }
    
   
}
