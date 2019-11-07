using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MvcWeb.Db;
using MvcWeb.TheraLang.Entities;

namespace TheraLang.DataSeeding
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            using var dbContext = CreateDbContext();

            dbContext.ClearAndSeed(Projects());
        }

        static IEnumerable<Project> Projects()
        {
            yield return new Project
            {
                Name = "ProjectName",
                Type = "ProjectType",
            };
            yield return new Project
            {
                Name = "ProjectName",
                Type = "ProjectType",
            };
        }
        
        static DbContext CreateDbContext()
        {
            var configurationBuilder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json");
            var configuration = configurationBuilder.Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var dbContextOptionsBuilder = new DbContextOptionsBuilder()
                .UseSqlServer(connectionString);
            var dbContextOptions = dbContextOptionsBuilder.Options;

            return new IttmmDbContext(dbContextOptions);
        }
    }
}