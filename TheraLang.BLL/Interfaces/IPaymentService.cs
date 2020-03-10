using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects.Donations;

namespace TheraLang.BLL.Interfaces
{
    public interface IPaymentService
    {
        public Task TopUpBalance(LiqPayCheckoutDto liqPayCheckoutDt);
    }
}
