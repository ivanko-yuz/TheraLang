using System.Collections.Generic;
using TheraLang.DAL.Entities;

namespace TheraLang.Tests.DataBuilders.ResourcesBuilders
{
    public class ResourceCategoryEntityTestBuilder : IDataBuilder<ResourceCategory>
    {
        private readonly ResourceCategory _resourceCategory;

        public ResourceCategoryEntityTestBuilder()
        {
            _resourceCategory = new ResourceCategory();
        }

        public ResourceCategoryEntityTestBuilder WithDefaultValues()
        {
            _resourceCategory.Id = DefaultValues.IntId;
            _resourceCategory.Type = DefaultValues.Name;
            return this;
        }

        public ResourceCategoryEntityTestBuilder WithId(int id)
        {
            _resourceCategory.Id = id;
            return this;
        }

        public ResourceCategoryEntityTestBuilder WithType(string type)
        {
            _resourceCategory.Type = type;
            return this;
        }

        public ResourceCategoryEntityTestBuilder WithResources(ICollection<Resource> resources)
        {
            _resourceCategory.Resources = resources;
            return this;
        }


        public ResourceCategory Build()
        {
            return _resourceCategory;
        }
    }
}