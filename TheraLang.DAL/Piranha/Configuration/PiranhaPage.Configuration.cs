using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.DAL.Piranha.Entities;

namespace TheraLang.DAL.Piranha.Configuration
{
    public class PiranhaPageConfiguration : IEntityTypeConfiguration<PiranhaPage>
    {
        public void Configure(EntityTypeBuilder<PiranhaPage> builder)
        {
            builder.ToTable("Piranha_Pages");

            builder.HasIndex(e => e.PageTypeId);

            builder.HasIndex(e => e.ParentId);

            builder.HasIndex(e => new {e.SiteId, e.Slug})
                .IsUnique();

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.ContentType)
                .IsRequired()
                .HasMaxLength(255)
                .HasDefaultValueSql("(N'Page')");

            builder.Property(e => e.MetaDescription).HasMaxLength(256);

            builder.Property(e => e.MetaKeywords).HasMaxLength(128);

            builder.Property(e => e.NavigationTitle).HasMaxLength(128);

            builder.Property(e => e.PageTypeId)
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

            builder.HasOne(d => d.PageType)
                .WithMany(p => p.PiranhaPages)
                .HasForeignKey(d => d.PageTypeId);

            builder.HasOne(d => d.Parent)
                .WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId);

            builder.HasOne(d => d.Site)
                .WithMany(p => p.PiranhaPages)
                .HasForeignKey(d => d.SiteId);
        }
    }
}