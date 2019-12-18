using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using TheraLang.DLL;
using TheraLang.DLL.Entities;

namespace TheraLang.DataSeeding
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            using var dbContext = CreateDbContext();

            dbContext.Clear<Donation>();
            dbContext.Clear<ProjectParticipation>();
            dbContext.Clear<ResourceProject>();
            dbContext.Clear<Project>();
            dbContext.Clear<Resource>();
            dbContext.Clear<ResourceCategory>();
            dbContext.Clear<ProjectType>();
            
            var projectTypes = ProjectTypes().ToArray();
            dbContext.Seed(projectTypes);
            dbContext.Seed(Projects(projectTypes));

            var resourceCategories = ResourceCategories().ToArray();
            dbContext.Seed(resourceCategories);
            //dbContext.Seed(Resources(resourceCategories));
        }

        private static IEnumerable<Project> Projects(ProjectType[] projectTypes)
        {
            yield return new Project
            {
                Name = "ProjectName",
                Description = "ProjectDescription",
                Details = "ProjectDetails",
                ProjectStart = new DateTime(2000, 8, 30),
                ProjectEnd = new DateTime(2019, 8, 30),
                IsActive = true,
                TypeId = projectTypes[0].Id,
            };
        }
        private static IEnumerable<ProjectType> ProjectTypes()
        {
            yield return new ProjectType
            {
                TypeName = "ProjectType1"
            };
            yield return new ProjectType
            {
                TypeName = "ProjectType2"
            };
        }

        private static IEnumerable<ResourceCategory> ResourceCategories()
        {
            yield return new ResourceCategory
            {
                Type = "ResourceCategory1"
            };
        }
        
        private static IEnumerable<Resource> Resources(ResourceCategory[] resourceCategories)
        {
            yield return new Resource
            {
                Name = "Name1",
                Description = "Description1",
                ResourceCategory = resourceCategories[0],
                Url = "https://google.com/"
                
            };
        }
        private static DbContext CreateDbContext()
        {

            var configurationBuilder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true);

            var configuration = configurationBuilder.Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var dbContextOptionsBuilder = new DbContextOptionsBuilder()
                .UseSqlServer(connectionString);
            var dbContextOptions = dbContextOptionsBuilder.Options;

            return new IttmmDbContext(dbContextOptions);
        }
    };
}