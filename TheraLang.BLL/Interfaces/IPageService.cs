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
        Task<PageDto> GetPageByRoute(string route);
        Task<PageDto> GetPageById(int id);
        Task<IEnumerable<PageDto>> GetAllPages();
    }
}
