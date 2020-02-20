using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.DAL.Entities;

namespace TheraLang.DAL.Configuration
{
    class NewsCommentConfiguration : IEntityTypeConfiguration<NewsComment>
    {
        public void Configure(EntityTypeBuilder<NewsComment> builder)
        {
            builder.ToTable("NewsComments");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Text).IsRequired().HasMaxLength(1000);
            builder.Property(e => e.CreatedById).IsRequired();
            builder.Property(e => e.CreatedDateUtc).IsRequired();
            builder.HasOne(e => e.Author).WithMany(a => a.Comments).HasForeignKey(c => c.CreatedById)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.News).WithMany(n => n.Comments).HasForeignKey(c => c.NewsId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
