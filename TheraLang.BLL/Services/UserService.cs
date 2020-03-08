using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.DAL.Entities;
using TheraLang.DAL.UnitOfWork;

namespace TheraLang.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileService _fileService;

        public UserService(IUnitOfWork unitOfWork, IFileService fileService)
        {
            _unitOfWork = unitOfWork;
            _fileService = fileService;
        }

        public async Task<UserAllDto> GetMyProfile(Guid id)
        {
            try
            {
                var user = await _unitOfWork.Repository<User>().Get(u => u.Id == id);

                var userDetails = await _unitOfWork.Repository<UserDetails>().GetAll()
                    .Include(ud => ud.User)
                    .FirstOrDefaultAsync(ud => ud.UserDetailsId == id);
                var detailsMapper = new MapperConfiguration(cfg =>
                    cfg.CreateMap<UserDetails, UserAllDto>()
                        .ForMember(userAllDto => userAllDto.Email,
                            opts => opts.MapFrom(details => details.User.Email))).CreateMapper();
                var userAll = detailsMapper.Map<UserDetails, UserAllDto>(userDetails);
                return userAll;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when getting user by {nameof(id)}={id}: ", ex);
            }
        }

        public async Task<UserDetailsDto> GetUserDetailsById(Guid id)
        {
            try
            {
                var user = await _unitOfWork.Repository<UserDetails>().Get(u => u.UserDetailsId == id);

                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<UserDetails, UserDetailsDto>())
                    .CreateMapper();
                var userDto = mapper.Map<UserDetails, UserDetailsDto>(user);

                return userDto;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when getting user by {nameof(id)}={id}: ", ex);
            }
        }

        public async Task<IEnumerable<UsersDto>> GetAllUsers()
        {
            
                var users = await _unitOfWork.Repository<UserDetails>().GetAllAsync();
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<UserDetails, UsersDto>())
                    .CreateMapper();
                var usersDto = mapper.Map<IEnumerable<UserDetails>, IEnumerable<UsersDto>>(users);
                return usersDto;
            }


        public async Task Update(UserDetailsDto user, Guid id)
        {
            try
            {
                var updateUser = await _unitOfWork.Repository<UserDetails>().Get(u => u.UserDetailsId == id);

                updateUser.FirstName = user.FirstName;
                updateUser.LastName = user.LastName;
                updateUser.PhoneNumber = user.PhoneNumber;
                updateUser.BirthdayDate = user.BirthdayDate;
                updateUser.City = user.City;
                updateUser.ShortInformation = user.ShortInformation;

                if (user.Image != null)
                {
                    var imageUri = await _fileService.SaveFile(user.Image.OpenReadStream(),
                        Path.GetExtension(user.Image.Name));
                    updateUser.ImageURl = imageUri.ToString();
                }

                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Cannot update the {nameof(UserDetails)}.", ex);
            }
        }

        public async Task<bool> ChangeRole(Guid userId, Guid newRole)
        {
            var user = await _unitOfWork.Repository<User>().Get(u => u.Id == userId);
            user.RoleId = newRole;
            _unitOfWork.Repository<User>().Update(user);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<AdminUserViewDto> AdminUserView(Guid userId)
        {
            var userDetails = await _unitOfWork.Repository<UserDetails>().Get(u => u.UserDetailsId == userId);
            var user = await _unitOfWork.Repository<User>().Get(u => u.Id == userId);
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<UserDetails, AdminUserViewDto>()).CreateMapper();
            var userDto = mapper.Map<UserDetails, AdminUserViewDto>(userDetails);
            userDto.RoleName = (await _unitOfWork.Repository<Role>().Get(r => r.Id == user.RoleId)).Name;
            return userDto;
        }

        public async Task<IEnumerable<RolesListDto>> GetAllRols()
        {
            var Roles = await _unitOfWork.Repository<Role>().GetAllAsync();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Role, RolesListDto>()).CreateMapper();
            var rolessDto = mapper.Map<IEnumerable<Role>, IEnumerable<RolesListDto>>(Roles);
            return rolessDto;
        }

        public async Task<Guid> GetUserRole(Guid userId)
        {
            var user = await _unitOfWork.Repository<User>().Get(u => u.Id == userId);
            return user.RoleId;
        }
    }
}