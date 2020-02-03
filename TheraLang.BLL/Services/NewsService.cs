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
using Microsoft.AspNetCore.Http;

namespace TheraLang.BLL.Services
{
    public class NewsService : INewsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileService _fileService;

        public NewsService(IUnitOfWork unitOfWork, IFileService fileService)
        {
            _unitOfWork = unitOfWork;
            _fileService = fileService;
        }

        public IEnumerable<NewsFromServerDto> GetAllNews()
        {
            var news = _unitOfWork.Repository<News>().Get().ToList();
            
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<News, NewsFromServerDto>()).CreateMapper();
            var newsDtos = mapper.Map<IEnumerable<News>, IEnumerable<NewsFromServerDto>>(news);

            return newsDtos;
        }

        public NewsFromServerDto GetNewsById(int id)
        {
            var news = _unitOfWork.Repository<News>().Get().SingleOrDefault(n => n.Id == id);

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<News, NewsFromServerDto>()).CreateMapper();
            var newsDto = mapper.Map<News, NewsFromServerDto>(news);

            return newsDto;
        }

        public async Task AddNews(NewsToServerDto newsDto)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<NewsToServerDto, News>()).CreateMapper();
            
            var news = mapper.Map<NewsToServerDto, News>(newsDto);
            news.UploadedImageUrls = await UploadImages(newsDto.NewImages);

            await _unitOfWork.Repository<News>().Add(news);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task RemoveNews(int id)
        {
            var news = _unitOfWork.Repository<News>().Get().SingleOrDefault(i => i.Id == id);
            _unitOfWork.Repository<News>().Remove(news);

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateNews(int id, NewsToServerDto newsDto)
        {
            var newsToUpdate = _unitOfWork.Repository<News>().Get().FirstOrDefault(n => n.Id == id);

            newsToUpdate.Title = newsDto.Title;
            newsToUpdate.Text = newsDto.Text;
            
            foreach(var imageUrl in newsDto.UploadedImageUrls)
            {
                if(!newsToUpdate.UploadedImageUrls.Contains(imageUrl))
                {
                    //_fileService.DeleteFile(imageUrl); //TODO
                }
            }
            var newImageUrls = await UploadImages(newsDto.NewImages);
            newsToUpdate.UploadedImageUrls.Union(newImageUrls);
            
            _unitOfWork.Repository<News>().Update(newsToUpdate);
            await _unitOfWork.SaveChangesAsync();
        }

        private async Task<ICollection<string>> UploadImages(ICollection<IFormFile> images)
        {
            var imageUrls = new List<string>();
            foreach (var image in images)
            {
                var imageUri = await _fileService.SaveFile(image);
                imageUrls.Add(imageUri.ToString());
            }

            return imageUrls;
        }
    }
}
