using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Common;
using FluentAssertions;
using MockQueryable.Moq;
using Moq;
using TheraLang.BLL.Interfaces;
using TheraLang.BLL.Services;
using TheraLang.DAL.Entities;
using TheraLang.DAL.Repository;
using TheraLang.DAL.UnitOfWork;
using TheraLang.Tests.DataBuilders.ResourcesBuilders;
using Xunit;

namespace TheraLang.Tests.Services
{
    public class ResourceServiceTests
    {
        private ResourceService _resourceService;
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

            var addedId = await _resourceService.AddResource(resource, userGuid);

            var actual = _resources.FirstOrDefault(r => r.Id == addedId);

            actual.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(999)]
        public async Task GetResources_ShouldFilterByProjectId(int projectId)
        {
            FillTestData();
            BuildMocks();

            var actual = await _resourceService.GetResources(null,
                projectId,
                _defaultPaginationParams);

            var expected = _resources.Where(r => r.ResourceProjects.Any(rp => rp.ProjectId == projectId))
                .Select(r => new ResourceDtoTestBuilder().FromEntity(r).Build());

            actual.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(null, null, 3)]
        [InlineData(999, 999, 0)]
        public async Task GetResourcesCount_ShouldReturnCorrectCount(int? categoryId, int? projectId, int expected)
        {
            FillTestData();
            BuildMocks();

            var actual = await _resourceService.GetResourcesCount(categoryId, projectId);

            actual.Should().Be(expected);
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

            _resourceService = new ResourceService(_unitOfWorkMock.Object, _fileServiceMock.Object);
        }

        private void FillTestData()
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
                            LastName = "Lastname"
                        }
                    })
                    .WithResourceProjects(3, 1)
                    .Build(),
                new ResourceEntityTestBuilder()
                    .WithDefaultValues()
                    .WithId(2)
                    .WithUser(new User()
                    {
                        Details = new UserDetails()
                        {
                            FirstName = "Name",
                            LastName = "Lastname"
                        }
                    })
                    .WithResourceProjects(3, 10)
                    .Build(),
                new ResourceEntityTestBuilder()
                    .WithDefaultValues()
                    .WithId(3)
                    .WithUser(new User()
                    {
                        Details = new UserDetails()
                        {
                            FirstName = "Name",
                            LastName = "Lastname"
                        }
                    })
                    .WithResourceProjects(1, 20)
                    .Build(),
            });
        }
    }
}