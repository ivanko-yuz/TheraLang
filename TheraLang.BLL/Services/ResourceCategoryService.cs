using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.DAL.Entities;
using TheraLang.DAL.UnitOfWork;

namespace TheraLang.BLL.Services
{
    public class ResourceCategoryService : IResourceCategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ResourceCategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task ChangeTypeName(int categoryId, string newTypeName)
        {
            try
            {
                var category =
                    await _unitOfWork.Repository<ResourceCategory>().Get(i => i.Id == categoryId);
                category.Type = newTypeName;

                _unitOfWork.Repository<ResourceCategory>().Update(category);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error when changing resource category for {nameof(categoryId)}:{categoryId} " +
                                    $"and {nameof(newTypeName)}:{newTypeName}: ", ex);
            }
        }

        public async Task<IEnumerable<ResourceCategoryDto>> GetAllCategories()
        {
            var categories = await _unitOfWork.Repository<ResourceCategory>().GetAllAsync();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ResourceCategory, ResourceCategoryDto>())
                .CreateMapper();
            var categoriesDto = mapper.Map<IEnumerable<ResourceCategory>, IEnumerable<ResourceCategoryDto>>(categories);

            return categoriesDto;
        }
    }
}