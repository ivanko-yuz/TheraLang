using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Common.Enums;
using Microsoft.EntityFrameworkCore;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.DAL.Entities;
using TheraLang.DAL.UnitOfWork;

namespace TheraLang.BLL.Services
{
    public class SiteMapService : ISiteMapService
    {
        public async Task<IEnumerable<SiteMapDto>> GetAll(Language lang = default)
        {
            var query = _unitOfWork.Repository<Page>().GetAll();
            if (lang != default)
            {
                query = query.Where(p => p.Language == lang);
            }

            var entities = await query
                .Include(sm => sm.SubPages)
                .Include(sm => sm.PageRoute)
                .OrderBy(sm => sm.SortOrder)
                .ToListAsync();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Page, SiteMapDto>()
                .ForMember(dto => dto.SubPages,
                    opts =>
                        opts.MapFrom(entity => entity.SubPages.OrderBy(subpage => subpage.SortOrder)))
                .ForMember(dto => dto.Route,
                    opts => opts.MapFrom(entity => entity.PageRoute.Route))
            ).CreateMapper();

            var onlyRoots = mapper.Map<IEnumerable<Page>, IEnumerable<SiteMapDto>>(entities)
                .Where(sm => sm.ParentPageId == null).ToList();
        

            return onlyRoots;
        }

        private readonly IUnitOfWork _unitOfWork;

        public SiteMapService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task UpdateStructure(IEnumerable<SiteMapDto> siteMap)
        {
            var siteMapDtos = siteMap.ToList();
            var idsOfChanged = siteMapDtos.Select(sm => sm.Id).ToList();

            var entitiesToChange = await _unitOfWork.Repository<Page>().GetAllAsync(p =>
                idsOfChanged.Contains(p.Id));

            var entityDtoPairs = entitiesToChange.Join(siteMapDtos,
                etc => etc.Id, ce => ce.Id, (old, changed) =>
                    new
                    {
                        Entity = old,
                        NewValues = changed
                    });
            foreach (var pair in entityDtoPairs)
            {
                pair.Entity.ParentPageId = pair.NewValues.ParentPageId ?? pair.Entity.ParentPageId;
                if (pair.NewValues.ParentPageId == 0)
                {
                    pair.Entity.ParentPageId = null;
                }

                pair.Entity.SortOrder = pair.NewValues.SortOrder ?? pair.Entity.SortOrder;
            }

            await _unitOfWork.SaveChangesAsync();
        }
    }
}