using Common.Helpers.PasswordHelper;
using Microsoft.EntityFrameworkCore;
using System;
using TheraLang.DAL.Configuration;
using TheraLang.DAL.Entities;
using TheraLang.DAL.Piranha.Configuration;

namespace TheraLang.DAL
{
    public class IttmmDbContext : DbContext
    {
        public IttmmDbContext(DbContextOptions options) : base(options)
        {
            //Database.Migrate();
        }
        
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectType> Types { get; set; }
        public virtual DbSet<ResourceCategory> ResourceCategories { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<ResourceProject> ResourceProject { get; set; }
        public virtual DbSet<ProjectParticipation> ProjectParticipations { get; set; }
        public virtual DbSet<Donation> Donations { get; set; }
        public virtual DbSet<Society> Societies { get; set; }
        public virtual DbSet<ResourceAttachment> ResourceAttachments { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<UploadedNewsContentImage> UploadedFiles { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<MemberFee> MemberFees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectTypeConfigurationcs());
            modelBuilder.ApplyConfiguration(new ResourceCategoriesConfiguration());
            modelBuilder.ApplyConfiguration(new ResourceConfiguration());
            modelBuilder.ApplyConfiguration(new ResourceProjectConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectParticipationConfiguration());
            modelBuilder.ApplyConfiguration(new DonationConfiguration());
            modelBuilder.ApplyConfiguration(new SocietyConfiguration());
            modelBuilder.ApplyConfiguration(new ResourceAttachmentConfiguration());
            modelBuilder.ApplyConfiguration(new NewsConfiguration());
            modelBuilder.ApplyConfiguration(new UploadedNewsContentImageConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new PageConfiguration());
            modelBuilder.ApplyConfiguration(new MemberFeeConfiguration());
            var AdminRoleID = Guid.NewGuid();
            var MemberRoleId = Guid.NewGuid();
            modelBuilder.Entity<Role>().HasData(new Role { Id = AdminRoleID, Name = "Admin", NormalizedName = "ADMIN" });
            modelBuilder.Entity<Role>().HasData(new Role { Id = MemberRoleId, Name = "Member", NormalizedName = "MEMBER" });
            modelBuilder.Entity<Role>().HasData(new Role { Id = Guid.NewGuid(), Name = "Guest", NormalizedName = "GUEST" });
            modelBuilder.Entity<User>().HasData(new User { Id = Guid.NewGuid(), UserName = "Admin", PasswordHash = PasswordHasher.HashPassword("password"), RoleId = AdminRoleID });
            modelBuilder.Entity<User>().HasData(new User { Id = Guid.NewGuid(), UserName = "Member", PasswordHash = PasswordHasher.HashPassword("password"), RoleId = MemberRoleId });
        }
    }
}