using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.DAL.Entities;

namespace TheraLang.DAL.Configuration
{
    public class ResourceProjectConfiguration : IEntityTypeConfiguration<ResourceProject>
    {
        public void Configure(EntityTypeBuilder<ResourceProject> builder)
        {
            builder.ToTable("ResourceToProject");

            builder.HasKey(x => new {x.ProjectId, x.ResourceId});
        }
    }
}