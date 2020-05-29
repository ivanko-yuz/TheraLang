using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TheraLang.BLL.DataTransferObjects.UserDtos;
using TheraLang.BLL.Interfaces;
using TheraLang.DAL.Entities;
using TheraLang.DAL.UnitOfWork;
using Common;
using System.Linq;
using Common.Exceptions;
using TheraLang.BLL.CustomTypes;

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
            var user = await _unitOfWork.Repository<User>().Get(u => u.Id == id);

            var userDetails = await _unitOfWork.Repository<UserDetails>().GetAll()
                .Include(ud => ud.User)
                .FirstOrDefaultAsync(ud => ud.UserDetailsId == id);
            var detailsMapper = new MapperConfiguration(cfg =>
                cfg.CreateMap<UserDetails, UserAllDto>()
                    .ForMember(userAllDto => userAllDto.Email,
                        opts => opts.MapFrom(details => details.User.Email))
                    .ForMember(userAllDto => userAllDto.Id, opt => opt.MapFrom(details => details.UserDetailsId)))
                .CreateMapper();
            var userAll = detailsMapper.Map<UserDetails, UserAllDto>(userDetails);
            return userAll;
        }

        public async Task<UserDetailsDto> GetUserDetailsById(Guid id)
        {
            var user = await _unitOfWork.Repository<UserDetails>().Get(u => u.UserDetailsId == id);

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<UserDetails, UserDetailsDto>()).CreateMapper();
            var userDto = mapper.Map<UserDetails, UserDetailsDto>(user);

            return userDto;
        }

        public async Task<UsersListDto> GetAllUsers(PaginationParams pagination)
        {
            var users = await _unitOfWork.Repository<UserDetails>().GetAll().Skip((pagination.PageNumber - 1) * pagination.PageSize).Take(pagination.PageSize).ToListAsync();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<UserDetails, UsersDto>()).CreateMapper();
            var usersDto = mapper.Map<IEnumerable<UserDetails>, IEnumerable<UsersDto>>(users);
            foreach(var user in usersDto)
            {
                var roleId = await GetUserRole(user.UserDetailsId);
                var role = await _unitOfWork.Repository<Role>().Get(r => r.Id == roleId);
                user.RoleName = role.Name;
            }
            var usersList = new UsersListDto()
            {
                UserList = usersDto.ToList(),
                CountOfItems = await _unitOfWork.Repository<UserDetails>().GetAll().CountAsync()
            };

            return usersList;
        }

        private IQueryable<UserDetails> GetFilteredProjects(FilterQuery query)
        {
            var userDtos = _unitOfWork.Repository<UserDetails>()
                .GetAll();

            return query.UserFilter(userDtos);
        }


        public async Task Update(UserDetailsDto user, Guid id)
        {
            var updateUser = await _unitOfWork.Repository<UserDetails>().Get(u => u.UserDetailsId == id);

            updateUser.FirstName = user.FirstName;
            updateUser.LastName = user.LastName;
            updateUser.PhoneNumber = user.PhoneNumber;
            updateUser.BirthDay = user.BirthDay;
            updateUser.City = user.City;
            updateUser.ShortInformation = user.ShortInformation;

            if (user.Image != null)
            {
                var imageUri = await _fileService.SaveFile(user.Image.OpenReadStream(),
                    Path.GetExtension(user.Image.FileName));
                updateUser.ImageURl = imageUri.ToString();
            }

            await _unitOfWork.SaveChangesAsync();
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