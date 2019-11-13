using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcWeb.TheraLang.Entities;

namespace MvcWeb.TheraLang.Configuration
{
    public class ResourceConfiguration : BaseEntityConfiguration<Resource>
    {
        public override void Configure(EntityTypeBuilder<Resource> builder)
        {
            builder.ToTable("Resources");

            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.HasIndex(p => p.Name).IsUnique();
            builder.Property(p => p.Description).HasMaxLength(5000).IsRequired();
            builder.Property(i => i.CategoryId).IsRequired();
            builder.Property(i => i.Url).HasDefaultValue(null);
            builder.Property(i => i.File).HasDefaultValue(null);

            builder.HasMany(i => i.ResourceProjects).WithOne(r => r.Resource).HasForeignKey(f=>f.ResourceId);
            builder.HasOne(u => u.User).WithMany(y => y.Resources).HasForeignKey(c=>c.CreatedById);
        }
    }
}
