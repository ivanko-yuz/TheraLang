using Microsoft.EntityFrameworkCore;
using TheraLang.DAL.Configuration;
using TheraLang.DAL.Entities;
using TheraLang.DAL.Piranha.Configuration;
using TheraLang.DAL.Piranha.Entities;

namespace TheraLang.DAL
{
    public sealed class IttmmDbContext : DbContext
    {
        public IttmmDbContext(DbContextOptions options) : base(options)
        {
            //Database.Migrate();
        }

        #region UTTMM_Entities
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectType> Types { get; set; }
        public DbSet<ResourceCategory> ResourceCategories { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<ResourceProject> ResourceProject { get; set; }
        public DbSet<ProjectParticipation> ProjectParticipations { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Society> Societies { get; set; }
        public DbSet<ResourceAttachment> ResourceAttachments { get; set; }
        #endregion

        #region Piranha_Entities
        public DbSet<PiranhaAlias> PiranhaAliases { get; set; }
        public DbSet<PiranhaBlockField> PiranhaBlockFields { get; set; }
        public DbSet<PiranhaBlock> PiranhaBlocks { get; set; }
        public DbSet<PiranhaCategory> PiranhaCategories { get; set; }
        public DbSet<PiranhaMedia> PiranhaMedia { get; set; }
        public DbSet<PiranhaMediaFolder> PiranhaMediaFolders { get; set; }
        public DbSet<PiranhaMediaVersion> PiranhaMediaVersions { get; set; }
        public DbSet<PiranhaPageBlock> PiranhaPageBlocks { get; set; }
        public DbSet<PiranhaPageField> PiranhaPageFields { get; set; }
        public DbSet<PiranhaPageRevision> PiranhaPageRevisions { get; set; }
        public DbSet<PiranhaPageType> PiranhaPageTypes { get; set; }
        public DbSet<PiranhaPage> PiranhaPages { get; set; }
        public DbSet<PiranhaParam> PiranhaParams { get; set; }
        public DbSet<PiranhaPostBlock> PiranhaPostBlocks { get; set; }
        public DbSet<PiranhaPostField> PiranhaPostFields { get; set; }
        public DbSet<PiranhaPostRevision> PiranhaPostRevisions { get; set; }
        public DbSet<PiranhaPostTag> PiranhaPostTags { get; set; }
        public DbSet<PiranhaPostType> PiranhaPostTypes { get; set; }
        public DbSet<PiranhaPost> PiranhaPosts { get; set; }
        public DbSet<PiranhaRoleClaim> PiranhaRoleClaims { get; set; }
        public DbSet<PiranhaRole> PiranhaRoles { get; set; }
        public DbSet<PiranhaSiteField> PiranhaSiteFields { get; set; }
        public DbSet<PiranhaSiteType> PiranhaSiteTypes { get; set; }
        public DbSet<PiranhaSite> PiranhaSites { get; set; }
        public DbSet<PiranhaTag> PiranhaTags { get; set; }
        public DbSet<PiranhaUserClaim> PiranhaUserClaims { get; set; }
        public DbSet<PiranhaUserLogin> PiranhaUserLogins { get; set; }
        public DbSet<PiranhaUserRole> PiranhaUserRoles { get; set; }
        public DbSet<PiranhaUserToken> PiranhaUserTokens { get; set; }
        public DbSet<PiranhaUser> PiranhaUsers { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Piranha_Entities_Cfg
            modelBuilder.ApplyConfiguration(new PiranhaAliasConfiguration());
            modelBuilder.ApplyConfiguration(new PiranhaBlockFieldConfiguration());
            modelBuilder.ApplyConfiguration(new PiranhaBlockConfiguration());
            modelBuilder.ApplyConfiguration(new PiranhaCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new PiranhaMediaConfiguration());
            modelBuilder.ApplyConfiguration(new PiranhaMediaFolderConfiguration());
            modelBuilder.ApplyConfiguration(new PiranhaMediaVersionConfiguration());
            modelBuilder.ApplyConfiguration(new PiranhaPageBlockConfiguration());
            modelBuilder.ApplyConfiguration(new PiranhaPageFieldConfiguration());
            modelBuilder.ApplyConfiguration(new PiranhaPageRevisionConfiguration());
            modelBuilder.ApplyConfiguration(new PiranhaPageTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PiranhaPageConfiguration());
            modelBuilder.ApplyConfiguration(new PiranhaParamConfiguration());
            modelBuilder.ApplyConfiguration(new PiranhaPostBlockConfiguration());
            modelBuilder.ApplyConfiguration(new PiranhaPostFieldConfiguration());
            modelBuilder.ApplyConfiguration(new PiranhaPostRevisionConfiguration());
            modelBuilder.ApplyConfiguration(new PiranhaPostTagConfiguration());
            modelBuilder.ApplyConfiguration(new PiranhaPostTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PiranhaPostConfiguration());
            modelBuilder.ApplyConfiguration(new PiranhaRoleClaimConfiguration());
            modelBuilder.ApplyConfiguration(new PiranhaRoleConfiguration());
            modelBuilder.ApplyConfiguration(new PiranhaSiteFieldConfiguration());
            modelBuilder.ApplyConfiguration(new PiranhaSiteTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PiranhaSiteConfiguration());
            modelBuilder.ApplyConfiguration(new PiranhaTagConfiguration());
            modelBuilder.ApplyConfiguration(new PiranhaUserClaimConfiguration());
            modelBuilder.ApplyConfiguration(new PiranhaUserLoginConfiguration());
            modelBuilder.ApplyConfiguration(new PiranhaUserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new PiranhaUserTokenConfiguration());
            modelBuilder.ApplyConfiguration(new PiranhaUserConfiguration());
            modelBuilder.ApplyConfiguration(new PiranhaUserConfiguration());
            #endregion

            #region UTTMM_Entities_Cfg
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectTypeConfigurationcs());
            modelBuilder.ApplyConfiguration(new ResourceCategoriesConfiguration());
            modelBuilder.ApplyConfiguration(new ResourceConfiguration());
            modelBuilder.ApplyConfiguration(new ResourceProjectConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectParticipationConfiguration());
            modelBuilder.ApplyConfiguration(new DonationConfiguration());
            modelBuilder.ApplyConfiguration(new SocietyConfiguration());
            modelBuilder.ApplyConfiguration(new ResourceAttachmentConfiguration());
            #endregion
        }

    }
}