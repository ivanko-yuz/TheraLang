using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.DAL.Entities;

namespace TheraLang.BLL.Interfaces
{
    public interface IAuthenticateService
    {
        Task<string> Authenticate(User user);
        Task<AuthUser> GetAuthUserAsync();
        Task<AuthUser> TryGetAuthUserAsync();
    }
}