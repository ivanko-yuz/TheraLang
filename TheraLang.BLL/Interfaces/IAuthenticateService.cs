using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.DAL.Entities;

namespace TheraLang.BLL.Interfaces
{
    public interface IAuthenticateService
    {
        Task<string> AuthenticateAsync(LoginModelDto request);
        Task<AuthUser> GetAuthUserAsync();
    }
}
