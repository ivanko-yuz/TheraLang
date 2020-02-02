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
            builder.Property(p => p.Title).IsRequired().HasMaxLength(256);
            builder.Property(p => p.Content).HasMaxLength(5000);
            builder.Property(p => p.MenuName).HasMaxLength(32);
        }
    }
}