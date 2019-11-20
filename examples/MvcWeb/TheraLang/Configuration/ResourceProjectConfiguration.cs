using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcWeb.TheraLang.Entities;

namespace MvcWeb.TheraLang.Configuration
{
    public class ResourceProjectConfiguration : IEntityTypeConfiguration<ResourceToProject>
    {
        public void Configure(EntityTypeBuilder<ResourceToProject> builder)
        {
            builder.ToTable("ResourceToProject");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.ProjectId).IsRequired();
            builder.Property(x => x.ResourceId).IsRequired();
        }
    }
}
