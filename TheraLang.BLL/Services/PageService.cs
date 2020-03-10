using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Common.Enums;
using Microsoft.EntityFrameworkCore;
using TheraLang.BLL.CustomTypes;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.DAL.Entities;
using TheraLang.DAL.UnitOfWork;

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

        public async Task Add(IEnumerable<PageDto> pagesDto)
        {
            foreach (var pageDto in pagesDto)
            {
                pageDto.Content = pageDto.Content.TrimScript();
                pageDto.Content = await _htmlContentService.SavePictures(pageDto.Content);
            }

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PageDto, Page>()
                    .ForMember(c => c.Content, opt => opt.MapFrom(n => n.Content.ToString())))
                .CreateMapper();
            var pages = mapper.Map<IEnumerable<PageDto>, IEnumerable<Page>>(pagesDto);

            var route = new PageRoute() {Route = pagesDto.FirstOrDefault().Route};
            (pages as List<Page>).ForEach(p => p.PageRoute = route);

            try
            {
                _unitOfWork.Repository<Page>().AddRange(pages);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception e)
            {
                e.Data["page"] = pagesDto;
                throw;
            }
        }

        public async Task<IEnumerable<PageDto>> GetAllPages()
        {
            var pages = await _unitOfWork.Repository<Page>().GetAll()
                .Include(p => p.SubPages)
                .Include(p => p.PageRoute)
                .ToListAsync();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Page, PageDto>()
                    .ForMember(c => c.Content, opt => opt.MapFrom(n => new HtmlContent(n.Content)))
                    .ForMember(c => c.Route, opt => opt.MapFrom(c => c.PageRoute.Route)))
                .CreateMapper();
            var pagesDto = mapper.Map<IEnumerable<Page>, IEnumerable<PageDto>>(pages);

            return pagesDto;
        }

        public async Task<PageDto> GetPageByRoute(string route, Language lang)
        {
            var page = await _unitOfWork.Repository<Page>().GetAll()
                .Include(r => r.PageRoute)
                .SingleOrDefaultAsync(p => p.Language == lang && p.PageRoute.Route == route);

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Page, PageDto>()
                    .ForMember(c => c.Content, opt => opt.MapFrom(n => new HtmlContent(n.Content)))
                    .ForMember(c => c.Route, opt => opt.MapFrom(n => n.PageRoute.Route)))
                .CreateMapper();

            var pageDto = mapper.Map<Page, PageDto>(page);

            return pageDto;
        }

        public async Task<PageDto> GetPageById(int pageId)
        {
            var page = await _unitOfWork.Repository<Page>().GetAll()
                .Include(p => p.PageRoute)
                .SingleOrDefaultAsync(p => p.Id == pageId);

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Page, PageDto>()
                    .ForMember(c => c.Content, opt => opt.MapFrom(n => new HtmlContent(n.Content)))
                    .ForMember(c => c.Route, opt => opt.MapFrom(n => n.PageRoute.Route)))
                .CreateMapper();

            var pageDto = mapper.Map<Page, PageDto>(page);

            return pageDto;
        }

        public async Task UpdatePages(IEnumerable<PageDto> pagesDto, string route)
        {
            foreach (var pageDto in pagesDto)
            {
                pageDto.Content = pageDto.Content.TrimScript();
                pageDto.Content = await _htmlContentService.SavePictures(pageDto.Content);
            }

            var pages = await _unitOfWork.Repository<Page>().GetAll()
                .Include(p => p.PageRoute)
                .Where(p => p.PageRoute.Route == route)
                .ToListAsync();

            var _route = await _unitOfWork.Repository<PageRoute>()
                .Get(r => r.Route == pages.FirstOrDefault().PageRoute.Route);

            try
            {
                for (var i = 0; i < pagesDto.Count(); i++)
                {
                    pages.ElementAt(i).Header = pagesDto.ElementAt(i).Header;
                    pages.ElementAt(i).MenuTitle = pagesDto.ElementAt(i).MenuTitle;
                    pages.ElementAt(i).Content = pagesDto.ElementAt(i).Content.ToString();
                }

                _route.Route = pagesDto.FirstOrDefault().Route;

                pages.ForEach(p => _unitOfWork.Repository<Page>().Update(p));
                _unitOfWork.Repository<PageRoute>().Update(_route);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception e)
            {
                e.Data["page"] = pages;
                throw;
            }
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
            var page = await _unitOfWork.Repository<Page>().Get(p => p.Id == pageId);
            var route = await _unitOfWork.Repository<PageRoute>().Get(r => r.Route == page.PageRoute.Route);

            try
            {
                pageDto.Content = pageDto.Content.TrimScript();
                pageDto.Content = await _htmlContentService.SavePictures(pageDto.Content);
                page.Header = pageDto.Header;
                page.MenuTitle = pageDto.MenuTitle;
                page.Content = pageDto.Content.ToString();
                route.Route = pageDto.Route;

                _unitOfWork.Repository<Page>().Update(page);
                _unitOfWork.Repository<PageRoute>().Update(route);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception e)
            {
                e.Data["page"] = page;
                throw;
            }
        }

        public async Task<IEnumerable<PageDto>> GetPagesByRoute(string route)
        {
            var pages = await _unitOfWork.Repository<Page>().GetAll()
                .Include(p => p.PageRoute)
                .Where(p => p.PageRoute.Route == route)
                .ToListAsync();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Page, PageDto>()
                    .ForMember(c => c.Content, opt => opt.MapFrom(n => new HtmlContent(n.Content)))
                    .ForMember(c => c.Route, opt => opt.MapFrom(n => n.PageRoute.Route)))
                .CreateMapper();

            var pagesDto = mapper.Map<IEnumerable<Page>, IEnumerable<PageDto>>(pages);

            return pagesDto;
        }
    }
}