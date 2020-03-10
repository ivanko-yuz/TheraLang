using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects.Donations;

namespace TheraLang.BLL.Interfaces
{
    public interface IPaymentService
    {
        Task TopUpBalance(LiqPayCheckoutDto liqPayCheckoutDt);
    }
}
