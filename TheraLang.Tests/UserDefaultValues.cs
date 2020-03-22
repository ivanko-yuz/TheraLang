using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects.UserDtos;

namespace TheraLang.Tests
{
    public static class UserDefaultValues
    {
        public static readonly UserAllDto userAll = new UserAllDto()
        {
            Id = new Guid("507f555f-fd1c-4555-9540-1555e8c250f7"),
            FirstName = "Andriana",
            LastName = "Baran",
            Email = "andriana@gmail.com",
            Password = "password"
        };

        public static readonly UserAllDto myInfo = new UserAllDto()
        {
            Id = new Guid("507f555f-f31c-4555-9540-155333c250f7"),
            FirstName = "Andriana",
            LastName = "Baran",
            Email = "andriana@gmail.com",
        };

        public static readonly UserDetailsDto detailsDto = new UserDetailsDto
        {
            FirstName = "Andriana",
            LastName = "Baran",
            City = "Lviv",
            PhoneNumber = "3809654298768"
        };

        public static UsersDto userNumOne = new UsersDto { FirstName = "FirstName", LastName = "LastName", City = "city" };
        public static UsersDto userNumTwo = new UsersDto { FirstName = "Andriana", LastName = "Baran", ShortInformation = "info" };
        public static List<UsersDto> Users = new List<UsersDto>();
        public static IEnumerable<UsersDto> ListInit()
        {
            Users.Add(userNumOne);
            Users.Add(userNumTwo);
            return Users;
        }

        public static readonly UsersListDto usersListDto = new UsersListDto
        {
            UserList = ListInit(),
            CountOfItems = 2
        };

        public static readonly AdminUserViewDto userViewDto = new AdminUserViewDto
        {
            FirstName = "Andriana",
            LastName = "Baran",
            ShortInformation = "Info",
            RoleName = "Admin"
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



    }
}
