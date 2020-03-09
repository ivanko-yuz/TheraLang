using System.IO;
using System.Text;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.DAL.Entities;

namespace TheraLang.Tests.DataBuilders.ResourcesBuilders
{
    public class ResourceDtoTestBuilder : IDataBuilder<ResourceDto>
    {
        private ResourceDto _resource;

        public ResourceDtoTestBuilder()
        {
            _resource = new ResourceDto();
        }

        public ResourceDtoTestBuilder WithDefaultValues()
        {
            _resource.Id = 1;
            _resource.Name = "Doc";
            _resource.Description = "Very interesting description";
            _resource.CategoryId = 1;
            _resource.AuthorName = "Admin";
            return this;
        }

        public ResourceDtoTestBuilder WithId(int id)
        {
            _resource.Id = id;
            return this;
        }

        public ResourceDtoTestBuilder WithName(string name)
        {
            _resource.Name = name;
            return this;
        }

        public ResourceDtoTestBuilder WithDescription(string description)
        {
            _resource.Description = description;
            return this;
        }

        public ResourceDtoTestBuilder WithUrl(string url)
        {
            _resource.Url = url;
            return this;
        }

        public ResourceDtoTestBuilder WithFile(IFormFile file)
        {
            _resource.File = file;
            return this;
        }

        public ResourceDtoTestBuilder WithDummyFile()
        {
            _resource.File = new FormFile(new MemoryStream(Encoding.UTF8.GetBytes("This is a dummy file")), 0, 0,
                "Data", "dummy.txt");
            return this;
        }

        public ResourceDtoTestBuilder WithCategoryId(int id)
        {
            _resource.CategoryId = id;
            return this;
        }

        public ResourceDtoTestBuilder WithAuthorName(string authorName)
        {
            _resource.AuthorName = authorName;
            return this;
        }

        public ResourceDtoTestBuilder WithResourceCategory(ResourceCategoryDto resourceCategoryDto)
        {
            _resource.ResourceCategory = resourceCategoryDto;
            return this;
        }

        public ResourceDtoTestBuilder FromEntity(Resource entity)
        {
            var mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Resource, ResourceDto>()
                    .ForMember(dto => dto.AuthorName,
                        opts => opts.MapFrom(resource =>
                            $"{resource.User.Details.FirstName} {resource.User.Details.LastName}"));
            }).CreateMapper();

            _resource = mapper.Map<ResourceDto>(entity);
            return this;
        }

        public ResourceDto Build()
        {
            return _resource;
        }
    }
}