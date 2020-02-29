using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.DAL.Entities;

namespace TheraLang.DAL.Configuration
{
    public class ResourceConfiguration : BaseEntityConfiguration<Resource>
    {
        public override void Configure(EntityTypeBuilder<Resource> builder)
        {
            builder.ToTable("Resources");

            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
            builder.HasIndex(x => x.Name).IsUnique();
            builder.Property(x => x.Description).HasMaxLength(512).IsRequired();
            builder.Property(x => x.CategoryId).IsRequired();
            builder.Property(x => x.Url).HasMaxLength(256);

            builder.HasMany(x => x.ResourceProjects).WithOne(i => i.Resource).HasForeignKey(e => e.ResourceId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}