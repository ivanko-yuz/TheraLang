using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.DAL.Entities;

namespace TheraLang.DAL.Configuration
{
    class NewsConfiguration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.ToTable("News");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Title).HasMaxLength(250).IsRequired();
            builder.Property(e => e.Text).IsRequired();
            builder.Property(e => e.CreatedById).IsRequired();
            builder.Property(e => e.MainImageUrl).IsRequired();
            builder.HasMany(e => e.UploadedContentImages).WithOne(i => i.News).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.Author).WithMany(a => a.News).HasForeignKey(n => n.CreatedById)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
