using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.DAL.UnitOfWork;
using TheraLang.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace TheraLang.BLL.Services
{
    public class PageService : IPageService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PageService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task Add(PageDto pageDto)
        {
            var route = string.Join('-', pageDto.MenuName.Trim().ToLower().Split(" "));

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PageDto, Page>()
            .ForMember(m => m.Route, opt => opt.MapFrom(n => route)))
                .CreateMapper();
            var page = mapper.Map<PageDto, Page>(pageDto);

            try
            {
                await _unitOfWork.Repository<Page>().Add(page);
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
            var pages = await _unitOfWork.Repository<Page>().Get().Include(p => p.SubPages).ToListAsync();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Page, PageDto>())
                .CreateMapper();
            var pagesDto = mapper.Map<IEnumerable<Page>, IEnumerable<PageDto>>(pages);

            return pagesDto;
        }

        public async Task<PageDto> GetPageByRoute(string route)
        {
            var page = await _unitOfWork.Repository<Page>()
                .Get()
                .FirstOrDefaultAsync(p => p.Route == route);

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Page, PageDto>())
                .CreateMapper();

            var pageDto = mapper.Map<Page, PageDto>(page);

            return pageDto;
        }

        public async Task<PageDto> GetPageById(int pageId)
        {
            var page = await _unitOfWork.Repository<Page>()
                .Get()
                .FirstOrDefaultAsync(p => p.Id == pageId);

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Page, PageDto>())
                .CreateMapper();

            var pageDto = mapper.Map<Page, PageDto>(page);

            return pageDto;
        }

        public async Task Remove(int pageId)
        {
            var page = await _unitOfWork.Repository<Page>()
                 .Get()
                 .FirstOrDefaultAsync(p => p.Id == pageId);
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
            var page = await _unitOfWork.Repository<Page>()
                .Get()
                .FirstOrDefaultAsync(p => p.Id == pageId);
            try
            {
                page.Header = pageDto.Header;
                page.MenuName = pageDto.MenuName;
                page.Content = pageDto.Content;

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