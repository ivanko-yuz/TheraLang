using Common.Helpers.PasswordHelper;
using System;
using System.Collections.Generic;
using TheraLang.DAL;
using TheraLang.DAL.Entities;

namespace TheraLang.IntegrationTests.Infrastucture.TestDataSeeding
{
    class TestDataSeeder
    {
        private readonly IttmmDbContext _context;

        public TestDataSeeder(IttmmDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            _context.Roles.AddRange(GetSeedingRoles());
            _context.Users.AddRange(GetSeedingUsers());
            _context.News.AddRange(GetSeedingNews());
            _context.UsersDetails.AddRange(GetSeedingUsersDetails());
            _context.UsersConfirmation.AddRange(GetDeedingUsersConfirmation());

            _context.SaveChanges();
        }

        private List<News> GetSeedingNews()
        {
            var news = new List<News>()
            {
                new News()
                {
                    Title = "Title",
                    Text = "Text",
                    MainImageUrl = "url",
                    CreatedById = DefaultValues.AdminId
                },
                new News()
                {
                    Title = "Title",
                    Text = "Text",
                    MainImageUrl = "url",
                    CreatedById = DefaultValues.AdminId
                },
                new News()
                {
                    Title = "Title",
                    Text = "Text",
                    MainImageUrl = "url",
                    CreatedById = DefaultValues.AdminId
                }
            };
            return news;
        }

        private List<Role> GetSeedingRoles()
        {
            var roles = new List<Role>()
            {
                new Role() {Id = DefaultValues.AdminRoleId, Name = "Admin"},
                new Role() {Id = DefaultValues.MemberRoleId, Name = "Member"},
                new Role() {Id = DefaultValues.GuestRoleId, Name = "Guest"},
                new Role() {Id = DefaultValues.UnconfirmedRoleId, Name = "Unconfirmed"},
                new Role() {Id = DefaultValues.BlockedRoleId, Name = "Blocked"}
            };

            return roles;
        }

        private List<User> GetSeedingUsers()
        {
            var users = new List<User>()
            {
                new User()
                {
                    Id = DefaultValues.AdminId,
                    Email = "admin@utmm.com",
                    PasswordHash = PasswordHasher.HashPassword("password"),
                    RoleId = DefaultValues.AdminRoleId
                },
                new User
                {
                    Id = DefaultValues.MemberId,
                    Email = "member@utmm.com",
                    PasswordHash = PasswordHasher.HashPassword("password"),
                    RoleId = DefaultValues.MemberRoleId
                }
            };

            return users;
        }

        private List<UserDetails> GetSeedingUsersDetails()
        {
            var users = new List<UserDetails>
            {
                new UserDetails()
                {
                     UserDetailsId = DefaultValues.MemberId,
                     FirstName = DefaultValues.DefaultString,
                     LastName = DefaultValues.DefaultString,
                     PhoneNumber = DefaultValues.DefaultString,
                     BirthDay = DefaultValues.DefaultDate,
                     City = DefaultValues.DefaultString,
                     ShortInformation = DefaultValues.DefaultString,
                }
            };

            return users;
        }

        private List<UserConfirmation> GetDeedingUsersConfirmation()
        {
            var usersConfirmation = new List<UserConfirmation>
            {
                new UserConfirmation()
                {
                    Id = DefaultValues.MemberId,
                    ConfDateTime = DateTime.Now,
                    Number = 123456
                }
            };

            return usersConfirmation;
        }
    }
}
