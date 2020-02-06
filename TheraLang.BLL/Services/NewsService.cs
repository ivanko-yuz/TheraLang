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
using Microsoft.EntityFrameworkCore;
using TheraLang.BLL.DataTransferObjects.NewsDtos;

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

        public async Task<IEnumerable<NewsPreviewDto>> GetAllNews()
        {
            var news = await _unitOfWork.Repository<News>().Get().Include(e => e.UploadedImages).ToListAsync();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<News, NewsPreviewDto>()
                .ForMember(m => m.PreviewImageUrl,
                        opt => opt.MapFrom(sm => sm.UploadedImages.Select(i => i.Url).FirstOrDefault()))
            ).CreateMapper();

            var newsDtos = mapper.Map<IEnumerable<News>, IEnumerable<NewsPreviewDto>>(news);

            return newsDtos;
        }

        public async Task<NewsDetailsDto> GetNewsById(int id)
        {
            var news = await _unitOfWork.Repository<News>().Get().
                    Include(e => e.UploadedImages).SingleOrDefaultAsync(n => n.Id == id);

            var mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<News, NewsDetailsDto>()
                    .ForMember(m => m.UploadedImageUrls, opt => opt.MapFrom(sm => sm.UploadedImages.Select(i => i.Url)));
            }).CreateMapper();

            var newsDto = mapper.Map<News, NewsDetailsDto>(news);

            return newsDto;
        }

        public async Task AddNews(NewsToServerDto newsDto)
        {
            var mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<string, UploadedNewsImage>().ForMember(f => f.Url, opt => opt.MapFrom(s => s));
                cfg.CreateMap<NewsToServerDto, News>()
                    .ForMember(m => m.UploadedImages, opt => opt.MapFrom(sm => sm.UploadedImageUrls));
            }).CreateMapper();

            var news = mapper.Map<NewsToServerDto, News>(newsDto);
            news.UploadedImages = await UploadImages(newsDto.NewImages);

            await _unitOfWork.Repository<News>().Add(news);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task RemoveNews(int id)
        {
            var news = _unitOfWork.Repository<News>().Get().SingleOrDefault(i => i.Id == id);

            if(news == default)
            {
                throw new ArgumentException($"News with id {id} not found!");
            }

            _unitOfWork.Repository<News>().Remove(news);

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateNews(int id, NewsToServerDto newsDto)
        {
            var newsToUpdate = await _unitOfWork.Repository<News>().Get().FirstOrDefaultAsync(n => n.Id == id);

            if (newsToUpdate == default)
            {
                throw new ArgumentException($"News with id {id} not found!");
            }

            newsToUpdate.Title = newsDto.Title;
            newsToUpdate.Text = newsDto.Text;

            var newImageUrls = await UploadImages(newsDto.NewImages);

            if (newsToUpdate.UploadedImages == null) newsToUpdate.UploadedImages = new List<UploadedNewsImage>();
            newsToUpdate.UploadedImages = newsToUpdate.UploadedImages.Union(newImageUrls).ToList();

            _unitOfWork.Repository<News>().Update(newsToUpdate);
            await _unitOfWork.SaveChangesAsync();
        }

        private async Task<ICollection<UploadedNewsImage>> UploadImages(ICollection<IFormFile> images)
        {
            var uploadedImages = new List<UploadedNewsImage>();
            foreach (var image in images)
            {
                var imageUrl = await _fileService.SaveFile(image);
                var uploadedImage = new UploadedNewsImage() { Url = imageUrl.ToString() };
                //await _unitOfWork.Repository<UploadedFile>().Add(uploadedImage);
                //await _unitOfWork.SaveChangesAsync();
                uploadedImages.Add(uploadedImage);
                //TODO: Service that will save file to server and add record to UploadedFiles table
            }

            return uploadedImages;
        }
    }
}
