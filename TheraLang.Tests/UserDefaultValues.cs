using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.DataTransferObjects.UserDtos;

namespace TheraLang.Tests
{
    public static class UserDefaultValues
    {
        public static string DefaultString = "SomeString";
        public static DateTime DefaultBirthDate = new DateTime(2017, 7, 15);
        public static Guid DefaultRoleId = new Guid("3f857412-cf5e-4087-bc85-6426fa791d91");
        public static Guid DefaultId = new Guid("54e7ed49-6d82-4045-a3fb-a9188f8c4816");
        public static string DefaultConfirmNum = "1238328";
        public static string DefaultPathTo = "welcome.html";
        public static string DefaultEmail = "andriana@gmail.com";
        public static string DefaultRoleName = "Member";

        public static DateTime FakeBirthDate = new DateTime(2018, 9, 23);
        public static Guid FakeRoleId = new Guid("fd873b92-5fd0-4521-98e6-da1f46b57cdb");
        public static Guid FakeId = new Guid("207b701b-fe10-4f1b-80d8-47c772ea71d5");
        public static string FakeConfirmNum = "3764735";
        public static string FakeEmail = "someEmail@gmail.com";
        public static string FakeRoleName = "Guest";

        public static readonly UserAllDto userAll = new UserAllDto()
        {
            Id = DefaultId,
            FirstName = DefaultString,
            LastName = DefaultString,
            Email = DefaultEmail,
            Password = DefaultString
        };

        public static readonly UserAllDto myInfo = new UserAllDto()
        {
            Id = DefaultId,
            FirstName = DefaultString,
            LastName = DefaultString,
            BirthDay = DefaultBirthDate,
            City = DefaultString,
            ShortInformation = DefaultString,
            PhoneNumber = DefaultString
        };

        public static readonly UserDetailsDto detailsDto = new UserDetailsDto
        {
            FirstName = DefaultString,
            LastName = DefaultString,
            City = DefaultString,
            PhoneNumber = DefaultString,
            ShortInformation = DefaultString,
            BirthDay = DefaultBirthDate,
        };

        public static UsersDto user = new UsersDto
        {
            FirstName = DefaultString,
            LastName = DefaultString,
            City = DefaultString,
            ShortInformation = DefaultString,
            BirthDay = DefaultBirthDate,
            UserDetailsId = DefaultId,
            RoleName = DefaultRoleName
        };
        public static List<UsersDto> Users = new List<UsersDto>();
        public static IEnumerable<UsersDto> ListInit()
        {
            Users.Add(user);
            return Users;
        }

        public static readonly UsersListDto usersListDto = new UsersListDto
        {
            UserList = ListInit(),
            CountOfItems = Users.Count
        };

        public static readonly AdminUserViewDto userViewDto = new AdminUserViewDto
        {
            FirstName = DefaultString,
            LastName = DefaultString,
            ShortInformation = DefaultString,
            RoleName = DefaultRoleName
        };

        public static readonly RolesListDto roleNumOne = new RolesListDto
        {
            Id = new Guid("fde18fbe-e9a5-4781-94ee-de7f1f0ad336"),
            Name = "Admin"
        };

        public static readonly RolesListDto roleNumTwo = new RolesListDto
        {
            Id = new Guid("bee2db7a-de6f-4d67-9bb6-6310adbe7671"),
            Name = "Member"
        };

        public static List<RolesListDto> Roles = new List<RolesListDto>();
        public static IEnumerable<RolesListDto> RolesListInit()
        {
            Roles.Add(roleNumOne);
            Roles.Add(roleNumTwo);
            return Roles;
        }
        public static readonly AuthUser authUser = new AuthUser
        {
            Id = DefaultId,
            UserEmail = DefaultEmail,
            Role = DefaultRoleName
        };

        public static readonly ConfirmUserDto ConfirmUser = new ConfirmUserDto
        {
            ConfirmationNumber = DefaultConfirmNum,
            Email = DefaultEmail
        };

        public static readonly ConfirmUserDto FakeConfirnmation = new ConfirmUserDto
        {
            ConfirmationNumber = FakeConfirmNum,
            Email = FakeEmail
        };

        public static readonly ConfirmPasswordChangingDto confirmPasswordChanging = new ConfirmPasswordChangingDto
        {
            Password = DefaultString,
            ConfirmPassword = DefaultString,
            Email = DefaultEmail,
            ConfirmationNumber = DefaultConfirmNum
        };


    }
}
