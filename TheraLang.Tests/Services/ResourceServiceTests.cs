using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Moq;
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
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly Mock<IFileService> _fileServiceMock;
        private readonly List<Resource> _resources = new List<Resource>();
        private readonly ResourceServiceBuilder _resourceServiceBuilder;
        
        public ResourceServiceTests()
        {
            var repoMock = new Mock<IRepository<Resource>>();
            repoMock.Setup(r => r.Add(It.IsAny<Resource>()))
                .Callback((Resource resource) => _resources.Add(resource));
            
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _unitOfWorkMock.Setup(u => u.Repository<Resource>()).Returns(repoMock.Object);
            
            _fileServiceMock = new Mock<IFileService>();
            _fileServiceMock.Setup(f => f.SaveFile(It.IsAny<Stream>(), It.IsAny<string>()))
                .ReturnsAsync(DefaultValues.Uri);
            
            _resourceServiceBuilder = new ResourceServiceBuilder()
                .WithUnitOfWork(_unitOfWorkMock.Object)
                .WithFileService(_fileServiceMock.Object);
        }

        [Fact]
        public async Task AddResource_ShouldFillFileUrl()
        {
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
    }
}