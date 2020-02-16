using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.Interfaces
{
    public interface IUserService
    {
        Task<UserAllDto> GetMyProfile(Guid id);
        Task<UserDetailsDto> GetUserDetailsById(Guid id);
        Task Update(UserDetailsDto user, Guid id);
        Task<IEnumerable<UsersDto>> GetAllUsers();
        Task<bool> ChangeRole(Guid userId, Guid newRole);
        Task<AdminUserViewDto> AdminUserView(Guid userId);
        Task<IEnumerable<RolesListDto>> GetAllRols();
        Task<Guid> GetUserRole(Guid userId);
    }

}
