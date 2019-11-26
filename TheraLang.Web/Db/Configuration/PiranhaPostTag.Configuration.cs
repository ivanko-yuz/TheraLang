using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.Web.Db.Entities;

namespace TheraLang.Web.Db.Configuration
{
    public class PiranhaPostTagConfiguration : IEntityTypeConfiguration<PiranhaPostTag>
    {
        public void Configure(EntityTypeBuilder<PiranhaPostTag> builder)
        {
            builder.HasKey(e => new {e.PostId, e.TagId});

            builder.ToTable("Piranha_PostTags");

            builder.HasIndex(e => e.TagId);

            builder.HasOne(d => d.Post)
                .WithMany(p => p.PiranhaPostTags)
                .HasForeignKey(d => d.PostId);

            builder.HasOne(d => d.Tag)
                .WithMany(p => p.PiranhaPostTags)
                .HasForeignKey(d => d.TagId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}