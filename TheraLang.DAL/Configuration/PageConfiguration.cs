using Common.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.DAL.Entities;

namespace TheraLang.DAL.Configuration
{
    public class PageConfiguration : IEntityTypeConfiguration<Page>
    {
        public void Configure(EntityTypeBuilder<Page> builder)
        {
            builder.ToTable("Pages");
            builder.Property(p => p.Header).IsRequired().HasMaxLength(128);
            builder.Property(p => p.Content).HasMaxLength(8000);
            builder.Property(p => p.MenuTitle).HasMaxLength(40);
            builder.Property(p => p.Language).IsRequired().HasDefaultValue(Language.Ua);
            builder.HasMany(p => p.SubPages)
                .WithOne(p => p.ParentPage)
                .HasForeignKey(p => p.ParentPageId);
        }
    }
}