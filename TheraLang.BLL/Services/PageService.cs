using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.DAL.UnitOfWork;
using TheraLang.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using TheraLang.BLL.CustomTypes;

namespace TheraLang.BLL.Services
{
    public class PageService : IPageService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHtmlContentService _htmlContentService;

        public PageService(IUnitOfWork unitOfWork, IHtmlContentService htmlContentService)
        {
            _unitOfWork = unitOfWork;
            _htmlContentService = htmlContentService;
        }

        public async Task Add(PageDto pageDto)
        {
            pageDto.Content = pageDto.Content.TrimScript();
            pageDto.Content = await _htmlContentService.SavePictures(pageDto.Content);

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PageDto, Page>()
                    .ForMember(c => c.Content, opt => opt.MapFrom(n => n.Content.ToString())))
                .CreateMapper();
            var page = mapper.Map<PageDto, Page>(pageDto);

            try
            {
                _unitOfWork.Repository<Page>().Add(page);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception e)
            {
                e.Data["page"] = pageDto;
                throw;
            }
        }

        public async Task<IEnumerable<PageDto>> GetAllPages()
        {
            var pages = await _unitOfWork.Repository<Page>().GetAll().Include(p => p.SubPages).ToListAsync();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Page, PageDto>()
                    .ForMember(c => c.Content, opt => opt.MapFrom(n => new HtmlContent(n.Content))))
                .CreateMapper();
            var pagesDto = mapper.Map<IEnumerable<Page>, IEnumerable<PageDto>>(pages);

            return pagesDto;
        }

        public async Task<PageDto> GetPageByRoute(string route)
        {
            var page = await _unitOfWork.Repository<Page>()
                .Get(p => p.Route == route);

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Page, PageDto>()
                    .ForMember(c => c.Content, opt => opt.MapFrom(n => new HtmlContent(n.Content))))
                .CreateMapper();

            var pageDto = mapper.Map<Page, PageDto>(page);

            return pageDto;
        }

        public async Task<PageDto> GetPageById(int pageId)
        {
            var page = await _unitOfWork.Repository<Page>()
                .Get(p => p.Id == pageId);

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Page, PageDto>()
                    .ForMember(c => c.Content, opt => opt.MapFrom(n => new HtmlContent(n.Content))))
                .CreateMapper();

            var pageDto = mapper.Map<Page, PageDto>(page);

            return pageDto;
        }

        public async Task Remove(int pageId)
        {
            var page = await _unitOfWork.Repository<Page>()
                .Get(p => p.Id == pageId);
            try
            {
                _unitOfWork.Repository<Page>().Remove(page);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception e)
            {
                e.Data["page"] = page;
                throw;
            }
        }

        public async Task Update(PageDto pageDto, int pageId)
        {
            pageDto.Content = pageDto.Content.TrimScript();

            var page = await _unitOfWork.Repository<Page>()
                .Get(p => p.Id == pageId);
            try
            {
                pageDto.Content = pageDto.Content.TrimScript();
                pageDto.Content = await _htmlContentService.SavePictures(pageDto.Content);
                page.Header = pageDto.Header;
                page.MenuName = pageDto.MenuName;
                page.Content = pageDto.Content.ToString();
                page.Route = pageDto.Route;
                
                _unitOfWork.Repository<Page>().Update(page);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception e)
            {
                e.Data["page"] = page;
                throw;
            }
        }
    }
}