using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.Interfaces
{
    public interface IPageService
    {
        Task Add(PageDto page);
        Task Update(PageDto page, int pageId);
        Task Remove(int pageId);
        Task<PageDto> GetPage(int pageId);
        Task<IEnumerable<PageDto>> GetAllPages();
    }
}
