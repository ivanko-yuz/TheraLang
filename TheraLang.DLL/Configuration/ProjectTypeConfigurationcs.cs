using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.DLL.Entities;

namespace TheraLang.DLL.Configuration
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

            builder.HasMany(e=>e.Projects).WithOne(x=>x.Type).
                HasForeignKey(i=>i.TypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}