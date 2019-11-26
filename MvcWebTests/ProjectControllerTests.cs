using Moq;
using MvcWeb.Controllers;
using MvcWeb.Services;
using MvcWeb.TheraLang.Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MvcWebTests
{
    [TestFixture]
    public class ProjectControllerTests
    {
        private IEnumerable<Project> GetTestProjects()
        {
            var projects = new List<Project>();
            projects.Add(new Project
            {
                Id = 1,
                TypeId = 1,
                Description = "descr",
                Details = "details",
                IsActive = false,
                ProjectStart = new DateTime(2019, 1, 1),
                ProjectEnd = new DateTime(2019, 2, 1)
            });
            projects.Add(new Project
            {
                Id = 2,
                TypeId = 1,
                Description = "descr2",
                Details = "details2",
                IsActive = true,
                ProjectStart = new DateTime(2019, 1, 1),
                ProjectEnd = new DateTime(2019, 2, 1)
            });
            return projects.ToList();
        }
        [Test]
        public void GetAllProjectsTest()
        {
            var mock = new Mock<IProjectService>();
            mock.Setup(repo => repo.GetAllProjects())
                .Returns(GetTestProjects());
            var controller = new ProjectController(mock.Object);
            var result = controller.GetAllProjects();
            Assert.AreEqual(2, GetTestProjects().Count());
            Assert.Pass();
        }
    }
}