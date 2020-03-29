using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheraLang.BLL.Interfaces;
using TheraLang.BLL.Services;
using TheraLang.DAL.Entities;
using TheraLang.DAL.UnitOfWork;
using TheraLang.Tests.DataBuilders.ResourcesBuilders;

namespace TheraLang.Tests.Mocks
{
    public class UserManagerServiceSetups
    {
        protected readonly Mock<IUnitOfWork> _unitOfWorkMock;
        protected readonly Mock<IFileService> _fileService;
        protected readonly Mock<IConfirmationService> _confirmationService;
        protected readonly UserManagementService _userService;
        protected readonly RepositoryMock<User> _userRepoMock;
        protected readonly RepositoryMock<UserDetails> _userDetailsRepoMock;
        protected readonly RepositoryMock<Role> _roleRepoMock;
        protected readonly RepositoryMock<UserConfirmation> _userConfirmationRepoMock;
        protected List<User> usersTestData;

        public UserManagerServiceSetups()
        {
            usersTestData = GetUsersTestData().ToList();
            _userRepoMock = new RepositoryMock<User>(usersTestData);
            _userDetailsRepoMock = new RepositoryMock<UserDetails>(GetUserDetailsTestData().ToList());
            _roleRepoMock = new RepositoryMock<Role>(GetRolesTestData().ToList());
            _userConfirmationRepoMock = new RepositoryMock<UserConfirmation>(GetUserConfirmationsTestData().ToList());

            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _unitOfWorkMock.Setup(u => u.Repository<User>()).Returns(_userRepoMock.Repository.Object);
            _unitOfWorkMock.Setup(u => u.Repository<Role>()).Returns(_roleRepoMock.Repository.Object);
            _unitOfWorkMock.Setup(u => u.Repository<UserDetails>()).Returns(_userDetailsRepoMock.Repository.Object);
            _unitOfWorkMock.Setup(u => u.Repository<UserConfirmation>()).Returns(_userConfirmationRepoMock.Repository.Object);
            _unitOfWorkMock.Setup(u => u.SaveChangesAsync()).Verifiable();
            _fileService = new Mock<IFileService>();
            _confirmationService = new Mock<IConfirmationService>();
            _confirmationService.Setup(x => x.SendEmail("", "", "")).Returns(Task.CompletedTask);

            _userService = new UserManagementService(_unitOfWorkMock.Object, _fileService.Object, _confirmationService.Object);
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

            Role role = new Role
            {
                Id = UserDefaultValues.DefaultRoleId,
                Name = UserDefaultValues.DefaultRoleName
            };

            data.Add(new User()
            {
                Id = UserDefaultValues.DefaultId,
                Email = UserDefaultValues.DefaultEmail,
                PasswordHash = Common.Helpers.PasswordHelper.PasswordHasher.HashPassword(UserDefaultValues.DefaultString),
                RoleId = UserDefaultValues.DefaultRoleId,
                Role = role

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
        private IEnumerable<UserConfirmation> GetUserConfirmationsTestData()
        {
            var data = new List<UserConfirmation>();
            data.Add(new UserConfirmation()
            {
                Id = UserDefaultValues.DefaultId,
                Number = Int32.Parse(UserDefaultValues.DefaultConfirmNum),
                ConfDateTime = DateTime.Now
            });

            return data.AsEnumerable();
        }
    }
}
