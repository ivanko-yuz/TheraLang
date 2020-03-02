using System;
using System.Linq;
using Common.Helpers.PasswordHelper;
using Microsoft.Extensions.DependencyInjection;
using TheraLang.DAL;
using TheraLang.DAL.Entities;

namespace DataSeeding
{
    public class DbInitializer
    {
        public void Seed(IServiceScope service)
        {
            try
            {
                var context = service.ServiceProvider.GetRequiredService<IttmmDbContext>();
                var adminRoleId = new Guid("f4cbff0f-4bc0-42a4-9738-8d9f9bb734ba");
                var memberRoleId = new Guid("50245ab3-6770-4269-ac26-30a942116a70");
                var guestRoleId = new Guid("7e9b3674-e720-4d50-939b-93ce8e8b1c44");
                var unconfirmedRoleId = new Guid("7e9b3674-e720-4d50-939b-55ce8e8b1c43");
                var blocked = new Guid("7e9b3674-4bc0-4d50-939b-53ce8e8b1c45");

                if (!context.Roles.Any())
                {
                    context.Roles.Add(new Role() {Id = adminRoleId, Name = "Admin"});
                    context.Roles.Add(new Role() {Id = memberRoleId, Name = "Member"});
                    context.Roles.Add(new Role() {Id = guestRoleId, Name = "Guest"});
                    context.Roles.Add(new Role() {Id = unconfirmedRoleId, Name = "Unconfirmed" });
                    context.Roles.Add(new Role() { Id = blocked, Name = "Blocked" });
                }

                if (!context.Users.Any())
                {
                    context.Users.Add(new User
                    {
                        Id = Guid.NewGuid(), Email = "admin@utmm.com",
                        PasswordHash = PasswordHasher.HashPassword("password"), RoleId = adminRoleId,
                    });
                    context.Users.Add(new User
                    {
                        Id = Guid.NewGuid(), Email = "member@utmm.com",
                        PasswordHash = PasswordHasher.HashPassword("password"), RoleId = memberRoleId,
                    });
                }
                context.SaveChanges();
            }
            catch (Exception)
            {
                
            }
        }
    }
}