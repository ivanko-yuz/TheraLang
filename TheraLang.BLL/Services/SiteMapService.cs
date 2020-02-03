using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.VisualBasic;
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
            var entities = await _unitOfWork.Repository<Page>().Get()
                .Include(sm => sm.SubPages)
                .ToListAsync();
            
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Page, SiteMapDto>()).CreateMapper();
            
            var onlyRoots = mapper.Map<IEnumerable<Page>, IEnumerable<SiteMapDto>>(entities)
                .Where(sm => sm.ParentPageId == null);
            return onlyRoots;
        }

        public async Task UpdateStructure(IEnumerable<SiteMapDto> siteMap)
        {
            var mapper = new MapperConfiguration(opts => opts.CreateMap<SiteMapDto,Page>())
                .CreateMapper();
            var flattened = Traverse(siteMap, sm => sm.SubPages);
            foreach (var siteMapDto in flattened)
            {
                if (siteMapDto.Changed)
                {
                    var entity = await _unitOfWork.Repository<Page>().Get()
                        .FirstOrDefaultAsync(sm => sm.Id == siteMapDto.Id);
                    
                    entity.SubPages
                }
            }
            return;
        }
        private static IEnumerable<T> Traverse<T>(IEnumerable<T> items, Func<T, IEnumerable<T>> childSelector)
        {
            var stack = new Stack<T>();
            foreach (var item in items)
            {
                stack.Push(item);
            }
            while (stack.Any())
            {
                var next = stack.Pop();
                yield return next;
                foreach (var child in childSelector(next))
                    stack.Push(child);
            }
        }
    }
}