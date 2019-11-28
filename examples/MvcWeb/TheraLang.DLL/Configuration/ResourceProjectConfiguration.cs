using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLangWeb.TheraLang.DLL.Entities;

namespace TheraLangWeb.TheraLang.DLL.Configuration
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
        }
    }
}
