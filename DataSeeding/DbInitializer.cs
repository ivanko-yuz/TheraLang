using Common.Helpers.PasswordHelper;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheraLang.DAL;
using TheraLang.DAL.Entities;

namespace DataSeeding
{
    public class DbInitializer
    {
        public void Seed(IServiceProvider service)
        {
            var context = service.GetRequiredService<IttmmDbContext>();
            var adminRoleId = Guid.NewGuid();
            var memberRoleId = Guid.NewGuid();
            var guestRoleId = Guid.NewGuid();
            if (!context.Roles.Any())
            {
                context.Roles.Add(new Role() { Id = adminRoleId, Name = "Admin" });
                context.Roles.Add(new Role() { Id = memberRoleId, Name = "Member" });
                context.Roles.Add(new Role() { Id = guestRoleId, Name = "Guest" });
            }

            if (!context.Users.Any())
            {
                context.Users.Add(new User { Id = Guid.NewGuid(), Email = "admin@utmm.com", PasswordHash = PasswordHasher.HashPassword("password"), RoleId = adminRoleId });
                context.Users.Add(new User { Id = Guid.NewGuid(), Email = "member@utmm.com", PasswordHash = PasswordHasher.HashPassword("password"), RoleId = memberRoleId });
            }

            context.SaveChanges();
        }
    }
}
