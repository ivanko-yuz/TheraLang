using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.DAL.Entities;

namespace TheraLang.BLL.Interfaces
{
    public interface IPaymentHistoryService
    {
        Task Add(PaymentHistoryDto paymentDto);
        Task<IEnumerable<PaymentHistoryDto>> GetByUserId(Guid userId);
        Task<IEnumerable<PaymentHistoryDto>> GetAll();
        Task<IEnumerable<PaymentHistoryDto>> GetHistoryPage(PagingParametersDto pagingParameters);
    }
}
