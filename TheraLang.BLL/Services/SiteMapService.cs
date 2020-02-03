using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.DAL.Entities;
using TheraLang.DAL.UnitOfWork;

namespace TheraLang.BLL.Services
{
    public class SiteMapService:ISiteMapService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SiteMapService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public async Task<IEnumerable<SiteMapDto>> GetAll()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Page, SiteMapDto>()).CreateMapper();
            var pageEntities = await _unitOfWork.Repository<Page>().Get().ToListAsync();
        }

        public async Task Add(SiteMapDto siteMap)
        {
            throw new System.NotImplementedException();
        }

        public async Task Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task Update(int id, SiteMapDto newSiteMap)
        {
            throw new System.NotImplementedException();
        }
    }
}