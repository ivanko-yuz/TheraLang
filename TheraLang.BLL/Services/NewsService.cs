using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
            var news = await _unitOfWork.Repository<News>().GetAll()
                    .Include(e => e.Author)
                    .Include(e => e.UploadedContentImages)
                    .ToListAsync();

            var mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<News, NewsPreviewDto>()
                    .ForMember(m => m.AuthorName, opt => opt.MapFrom(sm => sm.Author.UserName));
            }).CreateMapper();

            var newsDtos = mapper.Map<IEnumerable<News>, IEnumerable<NewsPreviewDto>>(news);

            return newsDtos;
        }

        public async Task<NewsDetailsDto> GetNewsById(int id)
        {
            var news = await _unitOfWork.Repository<News>().GetAll()
                    .Include(e => e.Author)
                    .Include(e => e.UploadedContentImages)
                    .Include(e => e.UsersThatLiked)
                    .SingleOrDefaultAsync(n => n.Id == id);

            var mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<News, NewsDetailsDto>()
                    .ForMember(m => m.ContentImageUrls, opt => opt.MapFrom(sm => sm.UploadedContentImages.Select(i => i.Url)))
                    .ForMember(m => m.AuthorName, opt => opt.MapFrom(sm => sm.Author.UserName))
                    .ForMember(m => m.LikesCount, opt => opt.MapFrom(sm => sm.UsersThatLiked.Count));
            }).CreateMapper();

            var newsDto = mapper.Map<News, NewsDetailsDto>(news);

            return newsDto;
        }

        public async Task AddNews(NewsCreateDto newsDto)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<NewsCreateDto, News>()).CreateMapper();

            var news = mapper.Map<NewsCreateDto, News>(newsDto);

            news.MainImageUrl = (await UploadImage(newsDto.MainImage)).Url;
            news.UploadedContentImages = new List<UploadedNewsContentImage>();
            foreach (var image in newsDto.ContentImages)
            {
                news.UploadedContentImages.Add(await UploadImage(image));
            }
            //news.UsersThatLiked = new List<User>();

            _unitOfWork.Repository<News>().Add(news);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task RemoveNews(int id)
        {
            var news = await _unitOfWork.Repository<News>().Get(i => i.Id == id);
            if (news == null)
            {
                throw new ArgumentNullException($"News with id {id} not found!");
            }

            _unitOfWork.Repository<News>().Remove(news);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateNews(int id, NewsEditDto newsDto)
        {
            var newsToUpdate = await _unitOfWork.Repository<News>().GetAll()
                    .Include(e => e.UploadedContentImages)
                    .SingleOrDefaultAsync(n => n.Id == id);

            if (newsToUpdate == null)
            {
                throw new ArgumentNullException($"News with id {id} not found!");
            }

            newsToUpdate.Title = newsDto.Title;
            newsToUpdate.Text = newsDto.Text;

            //update main image if need
            if (newsDto.NewMainImage != null)
            {
                //await DeleteImageFile(newsToUpdate.MainImageUrl);
                newsToUpdate.MainImageUrl = (await UploadImage(newsDto.NewMainImage)).Url;
            }

            //delete doesn't used images
            foreach (var uploadedImage in newsToUpdate.UploadedContentImages)
            {
                if (!newsDto.NotDeletedContentImageUrls.Contains(uploadedImage.Url))
                {
                    DeleteImage(uploadedImage);
                }
            }

            //upload new images
            foreach (var image in newsDto.AddedContentImages)
            {
                newsToUpdate.UploadedContentImages.Add(await UploadImage(image));
            }

            _unitOfWork.Repository<News>().Update(newsToUpdate);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task Like(int id, User user)
        {
            var newsToLike = await _unitOfWork.Repository<News>().GetAll()
                .Include(e=>e.UsersThatLiked)
                .SingleOrDefaultAsync(n => n.Id == id);
            
            //remove like if user already liked
            if(newsToLike.UsersThatLiked.Contains(user))
            {
                newsToLike.UsersThatLiked.Remove(user);
            }
            else
            {
                newsToLike.UsersThatLiked.Add(user);
            }

            _unitOfWork.Repository<News>().Update(newsToLike);
            await _unitOfWork.SaveChangesAsync();
        }

        private async Task<UploadedNewsContentImage> UploadImage(IFormFile image)
        {
            if (image == null) throw new ArgumentNullException();

            var imageUrl = await _fileService.SaveFile(image);
            var uploadedImage = new UploadedNewsContentImage() { Url = imageUrl.ToString() };
            return uploadedImage;
        }

        private void DeleteImage(UploadedNewsContentImage image)
        {
            //await DeleteImageFile(image.Url);
            _unitOfWork.Repository<UploadedNewsContentImage>().Remove(image);
        }

        //TODO
        //private async Task DeleteImageFile(string url)
        //{
        //    //delete file from storage something like that 
        //    //_fileService.DeleteFile(url);
        //}
    }
}
