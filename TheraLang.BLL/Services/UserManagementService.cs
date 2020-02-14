using Common.Helpers.PasswordHelper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheraLang.BLL.DataTransferObjects;
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

        public Task<User> GetUser(LoginModelDto loginModel)
        {
            var user = _unitOfWork.Repository<User>().Get(u => u.Email == loginModel.Email && PasswordHasher.VerifyHashedPassword(u.PasswordHash, loginModel.Password));
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