using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Common;
using FluentAssertions;
using MockQueryable.Moq;
using Moq;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.DAL.Entities;
using TheraLang.DAL.Repository;
using TheraLang.DAL.UnitOfWork;
using TheraLang.Tests.DataBuilders.ResourcesBuilders;
using TheraLang.Tests.DataBuilders.ServicesBuilders;
using Xunit;

namespace TheraLang.Tests.Services
{
    public class ResourceServiceTests
    {
        private ResourceServiceBuilder _resourceServiceBuilder;
        private Mock<IUnitOfWork> _unitOfWorkMock;
        private Mock<IFileService> _fileServiceMock;
        private readonly List<Resource> _resources;
        private readonly PaginationParams _defaultPaginationParams;

        public ResourceServiceTests()
        {
            _resources = new List<Resource>();
            _defaultPaginationParams = new PaginationParams()
            {
                PageNumber = 1,
                PageSize = Int32.MaxValue
            };
        }

        [Fact]
        public async Task AddResource_ShouldCallSaveChanges()
        {
            _resources.AddRange(new[]
            {
                new ResourceEntityTestBuilder()
                    .WithDefaultValues()
                    .WithId(1)
                    .WithUser(new User()
                    {
                        Details = new UserDetails()
                        {
                            FirstName = "Name",
                            LastName = "JHDSADJasd"
                        }
                    })
                    .WithResourceProjects(3, 1)
                    .Build(),
                new ResourceEntityTestBuilder()
                    .WithDefaultValues()
                    .WithId(2)
                    .WithResourceProjects(3, 10)
                    .Build(),
            });
            BuildMocks();
        }

        [Fact]
        public async Task AddResource_ShouldFillFileUrl()
        {
            BuildMocks();
            var resource = new ResourceDtoTestBuilder()
                .WithDefaultValues()
                .WithDummyFile()
                .Build();
            var userGuid = DefaultValues.Guid;

            var expected = new ResourceEntityTestBuilder()
                .WithDefaultValues()
                .WithCreatedById(DefaultValues.Guid)
                .WithUrl(DefaultValues.Uri.ToString())
                .Build();

            var resourceService = _resourceServiceBuilder.Buid();
            var addedId = await resourceService.AddResource(resource, userGuid);

            var actual = _resources.FirstOrDefault(r => r.Id == addedId);

            actual.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(999)]
        public async Task GetResources_ShouldFilterByProjectId(int projectId)
        {
            BuildMocks();
            var resourceService = _resourceServiceBuilder.Buid();
            var expected = _resources.Where(r => r.ResourceProjects.Any(rp => rp.ProjectId == projectId))
                .Select(r => new ResourceDtoTestBuilder().FromEntity(r).Build());

            var actual = await resourceService.GetResources(null,
                projectId,
                _defaultPaginationParams);

            
            actual.Should().BeEquivalentTo(expected);
        }

        private void BuildMocks()
        {
            var dbMock = _resources.AsQueryable().BuildMock();

            var repoMock = new Mock<IRepository<Resource>>();
            repoMock.Setup(r => r.Add(It.IsAny<Resource>())).Callback((Resource resource) => _resources.Add(resource));
            repoMock.Setup(r => r.GetAll()).Returns(dbMock.Object);

            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _unitOfWorkMock.Setup(u => u.Repository<Resource>()).Returns(repoMock.Object);

            _fileServiceMock = new Mock<IFileService>();
            _fileServiceMock.Setup(f => f.SaveFile(It.IsAny<Stream>(), It.IsAny<string>()))
                .ReturnsAsync(DefaultValues.Uri);

            _resourceServiceBuilder = new ResourceServiceBuilder().WithUnitOfWork(_unitOfWorkMock.Object)
                .WithFileService(_fileServiceMock.Object);
        }
    }
}