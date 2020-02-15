using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.DAL.UnitOfWork;
using TheraLang.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using TheraLang.BLL.CustomTypes;
using TheraLang.DAL.Enums;

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

            var route = await _unitOfWork.Repository<PageRoute>().Get(r => r.Route == pageDto.Route);
            page.PageRoute = route ?? new PageRoute() { Route = pageDto.Route };

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

        public async Task<PageDto> GetPageByRoute(string route, LanguageDto langDto)
        {
            var langMapper = new MapperConfiguration(cfg => cfg.CreateMap<LanguageDto, Language>()).CreateMapper();
            var lang = langMapper.Map<LanguageDto, Language>(langDto);

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
            var page = await _unitOfWork.Repository<Page>().Get(p => p.Id == pageId);
            var route = await _unitOfWork.Repository<PageRoute>().Get((r => r.Route == page.PageRoute.Route));

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
    }
}