using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.Interfaces
{
    public interface IMemberFeeService
    {
        Task<IEnumerable<MemberFeeDto>> GetMemberFeesAsync();
        Task AddAsync(MemberFeeDto memberFeeModel);
        Task DeleteAsync(int id);
    }
}