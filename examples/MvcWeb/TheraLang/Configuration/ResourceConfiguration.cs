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

            // builder.Property(b => b.CreatedDateUTC).HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.HasIndex(p => p.Name).IsUnique();
            builder.Property(p => p.Description).HasMaxLength(5000).IsRequired();

            builder.HasMany(r => r.ResourceProject).WithOne(rp => rp.Resource);
        }
    }
}
