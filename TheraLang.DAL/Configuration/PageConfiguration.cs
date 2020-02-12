using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.DAL.Entities;

namespace TheraLang.DAL.Configuration
{
    public class PageConfiguration:IEntityTypeConfiguration<Page>
    {
        public void Configure(EntityTypeBuilder<Page> builder)
        {
            builder.ToTable("Pages");
            builder.Property(p => p.Header).IsRequired().HasMaxLength(128);
            builder.Property(p => p.Content).HasMaxLength(8000);
            builder.Property(p => p.MenuName).HasMaxLength(32);
            builder.HasIndex(p => p.Route).IsUnique();
            builder.Property(e => e.Route)
                .IsRequired()
                .HasMaxLength(256);

            builder.HasMany(p => p.SubPages)
                .WithOne(p => p.ParentPage)
                .HasForeignKey(p => p.ParentPageId);
        }
    }
}