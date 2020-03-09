using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.DAL.Entities.ManyToMany;

namespace TheraLang.DAL.Configuration
{
    class NewsLikesConfiguration : IEntityTypeConfiguration<NewsLike>
    {
        public void Configure(EntityTypeBuilder<NewsLike> builder)
        {
            builder.ToTable("NewsLikes");

            builder.HasKey(e => new { e.NewsId, e.UserThatLikedId });

            builder.HasOne(e => e.News).WithMany(n => n.Likes).HasForeignKey(l => l.NewsId);
            builder.HasOne(e => e.UserThatLiked).WithMany(n => n.NewsLikes).HasForeignKey(l => l.UserThatLikedId);
        }
    }
}
