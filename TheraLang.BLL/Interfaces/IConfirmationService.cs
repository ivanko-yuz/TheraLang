using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects.UserDtos;

namespace TheraLang.BLL.Interfaces
{
    public interface IConfirmationService
    {
        Task SendEmail(string ConfirmNUm, string Email);
        Task ConfirmUser(ConfirmUserDto confirmUser);
    }
}
