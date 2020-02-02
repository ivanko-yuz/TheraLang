using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.Interfaces
{
    public interface INewsService
    {
        Task AddNews(NewsDto newsDto);

        Task UpdateNews(int id, NewsDto project);
        
        Task RemoveNews(int id);

        IEnumerable<NewsDto> GetAllNews();

        NewsDto GetNewsById(int id);
    }
}
