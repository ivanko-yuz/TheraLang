using Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.Interfaces
{
    public interface IPaymentHistoryService
    {
        Task Add(PaymentHistoryDto paymentDto);
        Task<IEnumerable<PaymentHistoryDto>> GetByUserId(Guid userId);
        Task<IEnumerable<PaymentHistoryDto>> GetAll();
        Task<IEnumerable<PaymentHistoryDto>> GetHistoryPage(PaginationParams pagingParameters);
        Task<IEnumerable<PaymentHistoryDto>> GetPageByUserId(Guid userId, PaginationParams pagingParameters);
        Task<int> GetUserPaymentHistoryCount(Guid userId);
        Task<int> GetAllPaymentHistoryCount();
    }
}
