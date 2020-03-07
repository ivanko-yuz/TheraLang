using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Helpers.PasswordHelper;
using TheraLang.DAL;
using TheraLang.DAL.Entities;

namespace TheraLang.DataSeeding
{
    internal static class Program
    {
        private static async Task Main(string[] args)
        {
            using var dbContext = CreateDbContext();
            var adminRoleId = new Guid("f4cbff0f-4bc0-42a4-9738-8d9f9bb734ba");
            var memberRoleId = new Guid("50245ab3-6770-4269-ac26-30a942116a70");
            var guestRoleId = new Guid("7e9b3674-e720-4d50-939b-93ce8e8b1c44");
            
            var adminId = new Guid("f5aa0c0e-b669-466c-825a-2c52c58a019b");
            var memberId = new Guid("3bcec608-e6a4-45e5-b3b2-cdf252a639de");
            var guestId = new Guid("29cf2d1c-6328-4861-a718-6a6bcc984337");

            var roles = new List<Role>()
            {
                new Role() {Id = adminRoleId, Name = "Admin"},
                new Role() {Id = memberRoleId, Name = "Member"},
                new Role() {Id = guestRoleId, Name = "Guest"}
            };
            
            var users = new List<User>()
            {
                new User()
                {
                    Id = adminId, Email = "admin@utmm.com",
                    PasswordHash = PasswordHasher.HashPassword("password"), RoleId = adminRoleId
                },
                new User
                {
                    Id = memberId, Email = "member@utmm.com",
                    PasswordHash = PasswordHasher.HashPassword("password"), RoleId = memberRoleId
                }
            };
            
            var resourceCategories = new List<ResourceCategory>()
            {
                new ResourceCategory()
                {
                    Type = "Файли"
                },
                new ResourceCategory()
                {
                    Type = "Зображення"
                },
                new ResourceCategory()
                {
                    Type = "Посилання"
                },

            };
            
            var userDetails = new List<UserDetails>()
            {
                new UserDetails()
                {
                    UserDetailsId = adminId,
                    FirstName = "Admin",
                    LastName = "Adminski"
                },
                new UserDetails()
                {
                    UserDetailsId = memberId,
                    FirstName = "Arturka",
                    LastName = "Member"
                }
            };

            var society = new List<Society>()
            {
                new Society()
                {
                    Name = "UTTMM"
                }
            };

            await dbContext.ClearAndSeed(roles);
            await dbContext.ClearAndSeed(users);
            await dbContext.ClearAndSeed(resourceCategories);
            await dbContext.ClearAndSeed(userDetails);
            await dbContext.ClearAndSeed(society);
        }
        
        private static DbContext CreateDbContext()
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
    };
}