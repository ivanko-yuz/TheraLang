using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcWeb.TheraLang.Entities;

namespace MvcWeb.TheraLang.Configuration
{
    public class ResourceProjectConfiguration : IEntityTypeConfiguration<ResourceProject>
    {
        public void Configure(EntityTypeBuilder<ResourceProject> builder)
        {
            builder.ToTable("ResourceToProject");

            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).ValueGeneratedOnAdd();

            builder.Property(i => i.ProjectId).IsRequired();
            builder.Property(r => r.ResourceId).IsRequired();
        }
    }
}
