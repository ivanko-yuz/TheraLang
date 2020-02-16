using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.DataTransferObjects.NewsDtos;
using TheraLang.DAL.Entities;

namespace TheraLang.BLL.Interfaces
{
    public interface INewsService
    {
        Task AddNews(NewsCreateDto newsDto);

        Task UpdateNews(int id, NewsEditDto newsDto);

        Task RemoveNews(int id);

        Task<IEnumerable<NewsPreviewDto>> GetAllNews();

        Task<int> GetNewsCount();

        Task<IEnumerable<NewsPreviewDto>> GetNewsPage(PagingParametersDto pageParameters);

        Task<NewsDetailsDto> GetNewsById(int id);

        Task Like(int id, User user);
    }
}
