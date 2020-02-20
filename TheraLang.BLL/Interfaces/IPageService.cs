using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.Interfaces
{
    public interface IPageService
    {
        Task Add(IEnumerable<PageDto> pages);
        Task Update(PageDto page, int pageId);
        Task UpdatePages(IEnumerable<PageDto> pages, string route);
        Task Remove(int pageId);
        Task<PageDto> GetPageByRoute(string route, LanguageDto lang);
        Task<PageDto> GetPageById(int id);
        Task<IEnumerable<PageDto>> GetAllPages();
        Task<IEnumerable<PageDto>> GetPagesByRoute(string route);
    }
}