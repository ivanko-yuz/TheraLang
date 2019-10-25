using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp.Db.Configuration
{
    public class PiranhaTagConfiguration:IEntityTypeConfiguration<PiranhaTag>
    {
        public void Configure(EntityTypeBuilder<PiranhaTag> builder)
        {
            builder.ToTable("Piranha_Tags");

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
                .WithMany(p => p.PiranhaTags)
                .HasForeignKey(d => d.BlogId);
        }
    }
}