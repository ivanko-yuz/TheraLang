using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.DLL.Entities;

namespace TheraLang.DLL.Configuration
{
    public class ResourceProjectConfiguration : IEntityTypeConfiguration<ResourceProject>
    {
        public void Configure(EntityTypeBuilder<ResourceProject> builder)
        {
            builder.ToTable("ResourceToProject");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.ProjectId).IsRequired();
            builder.Property(x => x.ResourceId).IsRequired();

            builder.HasIndex(x => new { x.ResourceId, x.ProjectId }).IsUnique();
        }
    }
}
