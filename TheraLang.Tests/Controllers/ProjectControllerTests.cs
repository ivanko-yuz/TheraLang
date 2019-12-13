using Moq;
using TheraLang.DLL.Entities;
using TheraLang.Web.Controllers;
using TheraLang.Web.Services;
using Xunit;

namespace TheraLang.Tests.Controllers
{
    public class ProjectControllerTests
    {
        private Mock<IProjectService> _projectServiceMock;
        private ProjectController _sutController;

        public ProjectControllerTests()
        {
            _projectServiceMock = new Mock<IProjectService>();
            _sutController = new ProjectController(_projectServiceMock.Object);
        }

        [Fact]
        public void CreateProject_IfModelIsValid_ShouldCallAddOnce()
        {
            // arrange
            var model = new Project
            {
                Name = nameof(CreateProject_IfModelIsValid_ShouldCallAddOnce)
            };

            // act
            _sutController.CreateProject(model);

            // assert
            _projectServiceMock.Verify(mock => mock.Add(It.IsAny<Project>()), Times.Once);
        }
    }
}