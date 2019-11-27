using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.DLL.Piranha.Entities;

namespace TheraLang.DLL.Piranha.Configuration
{
    public class PiranhaCategoryConfiguration : IEntityTypeConfiguration<PiranhaCategory>
    {
        public void Configure(EntityTypeBuilder<PiranhaCategory> builder)
        {
            builder.ToTable("Piranha_Categories");

            builder.HasIndex(e => new {e.BlogId, e.Slug})
                .IsUnique();

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.Slug)
                .IsRequired()
                .HasMaxLength(64);

            builder.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(64);

            builder.HasOne(d => d.Blog)
                .WithMany(p => p.PiranhaCategories)
                .HasForeignKey(d => d.BlogId);
        }
    }
}