using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.Interfaces
{
    public interface INewsService
    {
        Task AddNews(NewsToServerDto newsDto);

        Task UpdateNews(int id, NewsToServerDto newsDto);
        
        Task RemoveNews(int id);

        IEnumerable<NewsFromServerDto> GetAllNews();

        NewsFromServerDto GetNewsById(int id);
    }
}
