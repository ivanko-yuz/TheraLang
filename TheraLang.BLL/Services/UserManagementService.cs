using AutoMapper;
using Common.Helpers.PasswordHelper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public async Task<User> GetUserAsync(string userName, string password)
        {
            var user = await _unitOfWork.Repository<User>().GetWithIncludeAsync(
                u => u.UserName == userName && PasswordHasher.VerifyHashedPassword(u.PasswordHash, password), "Role");
            return user;
        }

        public async Task<User> GetUserByIdAsync(Guid id)
        {
            try
            {
                User user = await _unitOfWork.Repository<User>().GetAsync(u => u.Id == id);
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when getting project by {nameof(id)} = {id}: ", ex);
            }
        }
    }
}