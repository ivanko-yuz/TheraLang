using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using TheraLang.BLL.Interfaces;
using TheraLang.BLL.Services;
using TheraLang.DAL.Entities;
using TheraLang.DAL.UnitOfWork;
using TheraLang.Tests.DataBuilders.ResourcesBuilders;
using TheraLang.Tests.Mocks;

namespace TheraLang.Tests.Setups
{
   public  class UserServiceSetups
    {
        protected readonly Mock<IUnitOfWork> _unitOfWorkMock;
        protected readonly Mock<IFileService> _fileService;
        protected readonly UserService _userService;
        protected readonly RepositoryMock<User> _userRepoMock;
        protected readonly RepositoryMock<UserDetails> _userDetailsRepoMock;
        protected readonly RepositoryMock<Role> _roleRepoMock;

        public UserServiceSetups()
        {
            _userRepoMock = new RepositoryMock<User>(GetUsersTestData().ToList());
            _userDetailsRepoMock = new RepositoryMock<UserDetails>(GetUserDetailsTestData().ToList());
            _roleRepoMock = new RepositoryMock<Role>(GetRolesTestData().ToList());
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _unitOfWorkMock.Setup(u => u.Repository<User>()).Returns(_userRepoMock.Repository.Object);
            _unitOfWorkMock.Setup(u => u.Repository<Role>()).Returns(_roleRepoMock.Repository.Object);
            _unitOfWorkMock.Setup(u => u.Repository<UserDetails>()).Returns(_userDetailsRepoMock.Repository.Object);
            _unitOfWorkMock.Setup(u => u.SaveChangesAsync()).Verifiable();
            _fileService = new Mock<IFileService>();
            _userService = new UserService(_unitOfWorkMock.Object, _fileService.Object);
        }
        private IEnumerable<User> GetUsersTestData()
        {
            var data = new List<User>();

            for (int i = 0; i < DefaultValues.ListSize; i++)
            {
                var dataBuilder = new UserTestBuilder();
                data.Add(dataBuilder
                    .WithId(new Guid())
                    .WithDefault()
                    .Build());
            }
            data.Add(new User()
            {
                Id = UserDefaultValues.DefaultId,
                Email = UserDefaultValues.DefaultEmail,
                PasswordHash = UserDefaultValues.DefaultString,
                RoleId = UserDefaultValues.DefaultRoleId,

            });


            return data.AsEnumerable();
        }

        private IEnumerable<Role> GetRolesTestData()
        {
            var data = new List<Role>();

            data.Add(new Role()
            {
                Id = Guid.NewGuid(),
                Name = "Unconfirmed",
            });
            data.Add(new Role()
            {
                Id = UserDefaultValues.DefaultRoleId,
                Name = UserDefaultValues.DefaultRoleName
            });

            return data.AsEnumerable();
        }

        private IEnumerable<UserDetails> GetUserDetailsTestData()
        {
            var data = new List<UserDetails>();
            data.Add(new UserDetails()
            {
                UserDetailsId = UserDefaultValues.DefaultId,
                FirstName = UserDefaultValues.DefaultString,
                LastName = UserDefaultValues.DefaultString,
                City = UserDefaultValues.DefaultString,
                PhoneNumber = UserDefaultValues.DefaultString,
                ShortInformation = UserDefaultValues.DefaultString,
                BirthDay = UserDefaultValues.DefaultBirthDate
            });
            return data.AsEnumerable();
        }
    }
}
