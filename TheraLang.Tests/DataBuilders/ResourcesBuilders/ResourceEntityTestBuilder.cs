using System;
using TheraLang.DAL.Entities;

namespace TheraLang.Tests.DataBuilders.ResourcesBuilders
{
    public class ResourceEntityTestBuilder : IDataBuilder<Resource>
    {
        private readonly Resource _resource;

        public ResourceEntityTestBuilder()
        {
            _resource = new Resource();
        }

        public ResourceEntityTestBuilder WithDefaultValues()
        {
            _resource.Id = 1;
            _resource.Name = "Doc";
            _resource.Description = "Very interesting description";
            _resource.Url = "default url";
            _resource.CategoryId = 1;
            return this;
        }

        public ResourceEntityTestBuilder WithId(int id)
        {
            _resource.Id = id;
            return this;
        }

        public ResourceEntityTestBuilder WithName(string name)
        {
            _resource.Name = name;
            return this;
        }

        public ResourceEntityTestBuilder WithDescription(string description)
        {
            _resource.Description = description;
            return this;
        }

        public ResourceEntityTestBuilder WithUrl(string url)
        {
            _resource.Url = url;
            return this;
        }

        public ResourceEntityTestBuilder WithCategoryId(int id)
        {
            _resource.CategoryId = id;
            return this;
        }

        public ResourceEntityTestBuilder WithUser(User user)
        {
            _resource.User = user;
            return this;
        }

        public ResourceEntityTestBuilder WithResourceCategory(ResourceCategory resourceCategoryDto)
        {
            _resource.ResourceCategory = resourceCategoryDto;
            return this;
        }

        public ResourceEntityTestBuilder WithCreatedById(Guid id)
        {
            _resource.CreatedById = id;
            return this;
        }

        public ResourceEntityTestBuilder WithCreatedDateUtc(DateTime dateTime)
        {
            _resource.CreatedDateUtc = dateTime;
            return this;
        }

        public ResourceEntityTestBuilder WithUpdatedById(Guid id)
        {
            _resource.UpdatedById = id;
            return this;
        }

        public ResourceEntityTestBuilder WithUpdatedDateUtc(DateTime dateTime)
        {
            _resource.UpdatedDateUtc = dateTime;
            return this;
        }

        public Resource Build()
        {
            return _resource;
        }
    }
}