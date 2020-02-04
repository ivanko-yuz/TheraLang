using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.Interfaces
{
    public interface IAuthenticateService
    {
        Task<string> AuthenticateAsync(LoginModelDto request);
    }
}
