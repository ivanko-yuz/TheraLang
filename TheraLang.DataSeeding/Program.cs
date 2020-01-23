using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using TheraLang.DAL;
using TheraLang.DAL.Entities;

namespace TheraLang.DataSeeding
{
    internal static class Program
    {
        private static void Main()
        {
            using var dbContext = CreateDbContext();

            var projectTypes = ProjectTypes().ToArray();
            dbContext.ClearAndSeed(projectTypes);
            dbContext.ClearAndSeed(Projects(projectTypes));
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
                TypeName = "name"
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