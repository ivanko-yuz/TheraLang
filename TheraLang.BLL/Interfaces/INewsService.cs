using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects.NewsDtos;

namespace TheraLang.BLL.Interfaces
{
    public interface INewsService
    {
        Task AddNews(NewsCreateDto newsDto);

        Task UpdateNews(int id, NewsEditDto newsDto);
        
        Task RemoveNews(int id);

        Task<IEnumerable<NewsPreviewDto>> GetAllNews();

        Task<NewsDetailsDto> GetNewsById(int id);
    }
}
