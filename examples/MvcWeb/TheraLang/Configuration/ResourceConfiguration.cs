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

            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).ValueGeneratedOnAdd();
            builder.Property(i => i.CreatedbyId).IsRequired();
            builder.Property(i => i.CreatedDateUTC).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.HasIndex(p => p.Name).IsUnique();
            builder.Property(p => p.Description).HasMaxLength(5000).IsRequired();
            // Relationship.
            builder.HasMany(r => r.ResourceProject).WithOne(rp => rp.Resource);
        }
    }
}
