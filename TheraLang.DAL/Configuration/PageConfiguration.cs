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
            builder.Property(p => p.Content).HasMaxLength(5000);
            builder.Property(p => p.MenuName).HasMaxLength(32);
            builder.Property(p => p.Route).IsRequired().HasMaxLength(32);
            builder.HasIndex(p => p.Route).IsUnique();
            builder.HasMany(p => p.SubPages)
                .WithOne(p => p.ParentPage)
                .HasForeignKey(p => p.ParentPageId);
       
        }
    }
}