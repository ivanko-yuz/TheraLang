using Common.Helpers.PasswordHelper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using TheraLang.BLL.Interfaces;
using TheraLang.DAL.Entities;
using TheraLang.DAL.UnitOfWork;

namespace TheraLang.BLL.Services
{
    public class UserManagementService : IUserManagementService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserManagementService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<User> GetUser(string userName, string password)
        {
            var user = await _unitOfWork.Repository<User>().GetAll()
                    .Include(x => x.Role)
                .FirstOrDefaultAsync(u => u.UserName == userName && PasswordHasher.VerifyHashedPassword(u.PasswordHash, password));
            
            return user;
        }

        public async Task<User> GetUserById(Guid id)
        {
            try
            {
                var user = await _unitOfWork.Repository<User>().Get(u => u.Id == id);
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception($"Cannot get project with {nameof(id)}: {id}.", ex);
            }
        }
    }
}