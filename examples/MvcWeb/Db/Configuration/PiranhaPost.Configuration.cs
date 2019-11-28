using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLangWeb.Db.Entities;

namespace TheraLangWeb.Db.Configuration
{
    public class PiranhaPostConfiguration : IEntityTypeConfiguration<PiranhaPost>
    {
        public void Configure(EntityTypeBuilder<PiranhaPost> builder)
        {
            builder.ToTable("Piranha_Posts");

            builder.HasIndex(e => e.CategoryId);

            builder.HasIndex(e => e.PostTypeId);

            builder.HasIndex(e => new {e.BlogId, e.Slug})
                .IsUnique();

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.MetaDescription).HasMaxLength(256);

            builder.Property(e => e.MetaKeywords).HasMaxLength(128);

            builder.Property(e => e.PostTypeId)
                .IsRequired()
                .HasMaxLength(64);

            builder.Property(e => e.RedirectUrl).HasMaxLength(256);

            builder.Property(e => e.Route).HasMaxLength(256);

            builder.Property(e => e.Slug)
                .IsRequired()
                .HasMaxLength(128);

            builder.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(128);

            builder.HasOne(d => d.Blog)
                .WithMany(p => p.PiranhaPosts)
                .HasForeignKey(d => d.BlogId);

            builder.HasOne(d => d.Category)
                .WithMany(p => p.PiranhaPosts)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(d => d.PostType)
                .WithMany(p => p.PiranhaPosts)
                .HasForeignKey(d => d.PostTypeId);
        }
    }
}