using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.DAL.UnitOfWork;
using TheraLang.DAL.Entities;
using System.Linq;
using AutoMapper;

namespace TheraLang.BLL.Services
{
    public class NewsService : INewsService
    {
        private readonly IUnitOfWork _unitOfWork;

        public NewsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<NewsDto> GetAllNews()
        {
            var news = _unitOfWork.Repository<News>().Get().ToList();
            
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<News, NewsDto>()).CreateMapper();
            var newsDtos = mapper.Map<IEnumerable<News>, IEnumerable<NewsDto>>(news);

            return newsDtos;
        }

        public NewsDto GetNewsById(int id)
        {
            var news = _unitOfWork.Repository<News>().Get().SingleOrDefault(n => n.Id == id);

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<News, NewsDto>()).CreateMapper();
            var newsDto = mapper.Map<News, NewsDto>(news);

            return newsDto;
        }

        public async Task AddNews(NewsDto newsDto)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<NewsDto, News>()).CreateMapper();
            var news = mapper.Map<NewsDto, News>(newsDto);

            await _unitOfWork.Repository<News>().Add(news);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task RemoveNews(int id)
        {
            var news = _unitOfWork.Repository<News>().Get().SingleOrDefault(i => i.Id == id);
            _unitOfWork.Repository<News>().Remove(news);

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateNews(int id, NewsDto newsDto)
        {
            var oldNews = _unitOfWork.Repository<News>().Get().FirstOrDefault(n => n.Id == id);

            oldNews.Title = newsDto.Title;
            oldNews.Text = newsDto.Text;
            
            _unitOfWork.Repository<News>().Update(oldNews);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
