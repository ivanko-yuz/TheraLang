using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLangWeb.TheraLang.DLL.Entities;

namespace TheraLangWeb.TheraLang.DLL.Configuration
{
    public class ProjectTypeConfigurationcs : IEntityTypeConfiguration<ProjectType>
    {
        public void Configure(EntityTypeBuilder<ProjectType> builder)
        {
            builder.ToTable("Types");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.TypeName).HasMaxLength(500);

            builder.HasIndex(e => e.TypeName).IsUnique(true);
        }
    }
}