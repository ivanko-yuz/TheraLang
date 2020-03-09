using System;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects.UserDtos;
using TheraLang.DAL.Entities;

namespace TheraLang.BLL.Interfaces
{
    public interface IUserManagementService
    {
        Task<User> GetUser(string email, string password);

        Task<User> GetUserById(Guid id);

        Task AddUser(UserAllDto NewUser);
        Task PasswordConfirmationRequest(string Email);
    }
}