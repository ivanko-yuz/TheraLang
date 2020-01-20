using Microsoft.EntityFrameworkCore;
using TheraLang.DAL.Configuration;
using TheraLang.DAL.Entities;
using TheraLang.DAL.Piranha.Configuration;
using TheraLang.DAL.Piranha.Entities;

namespace TheraLang.DAL
{
    public class IttmmDbContext : DbContext
    {
        public IttmmDbContext(DbContextOptions options) : base(options)
        {
            //Database.Migrate();
        }

        #region UTTMM_Entities
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectType> Types { get; set; }
        public virtual DbSet<ResourceCategory> ResourceCategories { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<ResourceProject> ResourceProject { get; set; }
        public virtual DbSet<ProjectParticipation> ProjectParticipations { get; set; }
        public virtual DbSet<Donation> Donations { get; set; }
        public virtual DbSet<Society> Societies { get; set; }
        public virtual DbSet<ResourceAttachment> ResourceAttachments { get; set; }
        #endregion

        #region Piranha_Entities
        public virtual DbSet<PiranhaAlias> PiranhaAliases { get; set; }
        public virtual DbSet<PiranhaBlockField> PiranhaBlockFields { get; set; }
        public virtual DbSet<PiranhaBlock> PiranhaBlocks { get; set; }
        public virtual DbSet<PiranhaCategory> PiranhaCategories { get; set; }
        public virtual DbSet<PiranhaMedia> PiranhaMedia { get; set; }
        public virtual DbSet<PiranhaMediaFolder> PiranhaMediaFolders { get; set; }
        public virtual DbSet<PiranhaMediaVersion> PiranhaMediaVersions { get; set; }
        public virtual DbSet<PiranhaPageBlock> PiranhaPageBlocks { get; set; }
        public virtual DbSet<PiranhaPageField> PiranhaPageFields { get; set; }
        public virtual DbSet<PiranhaPageRevision> PiranhaPageRevisions { get; set; }
        public virtual DbSet<PiranhaPageType> PiranhaPageTypes { get; set; }
        public virtual DbSet<PiranhaPage> PiranhaPages { get; set; }
        public virtual DbSet<PiranhaParam> PiranhaParams { get; set; }
        public virtual DbSet<PiranhaPostBlock> PiranhaPostBlocks { get; set; }
        public virtual DbSet<PiranhaPostField> PiranhaPostFields { get; set; }
        public virtual DbSet<PiranhaPostRevision> PiranhaPostRevisions { get; set; }
        public virtual DbSet<PiranhaPostTag> PiranhaPostTags { get; set; }
        public virtual DbSet<PiranhaPostType> PiranhaPostTypes { get; set; }
        public virtual DbSet<PiranhaPost> PiranhaPosts { get; set; }
        public virtual DbSet<PiranhaRoleClaim> PiranhaRoleClaims { get; set; }
        public virtual DbSet<PiranhaRole> PiranhaRoles { get; set; }
        public virtual DbSet<PiranhaSiteField> PiranhaSiteFields { get; set; }
        public virtual DbSet<PiranhaSiteType> PiranhaSiteTypes { get; set; }
        public virtual DbSet<PiranhaSite> PiranhaSites { get; set; }
        public virtual DbSet<PiranhaTag> PiranhaTags { get; set; }
        public virtual DbSet<PiranhaUserClaim> PiranhaUserClaims { get; set; }
        public virtual DbSet<PiranhaUserLogin> PiranhaUserLogins { get; set; }
        public virtual DbSet<PiranhaUserRole> PiranhaUserRoles { get; set; }
        public virtual DbSet<PiranhaUserToken> PiranhaUserTokens { get; set; }
        public virtual DbSet<PiranhaUser> PiranhaUsers { get; set; }
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