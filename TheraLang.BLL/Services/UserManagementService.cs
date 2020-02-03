using AutoMapper;
using Common.Helpers.PasswordHelper;
using Microsoft.EntityFrameworkCore;
using System;
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
        public User GetUser(LoginModelDto loginModel)
        {

            var user = _unitOfWork.Repository<User>().Get().Include(x => x.Role).FirstOrDefault(u => u.UserName == loginModel.UserName && PasswordHasher.VerifyHashedPassword(u.PasswordHash, loginModel.Password));
            return user;
        }

        public User GetUserById(Guid id)
        {
            try
            {
                User user = _unitOfWork.Repository<User>().Get().FirstOrDefault(u => u.Id == id);
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when getting project by {nameof(id)} = {id}: ", ex);
            }
        }
    }
}
