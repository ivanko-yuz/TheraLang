using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.Web.Db.Entities;

namespace TheraLang.Web.Db.Configuration
{
    public class PiranhaPageRevisionConfiguration : IEntityTypeConfiguration<PiranhaPageRevision>
    {
        public void Configure(EntityTypeBuilder<PiranhaPageRevision> builder)
        {
            builder.ToTable("Piranha_PageRevisions");

            builder.HasIndex(e => e.PageId);

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.HasOne(d => d.Page)
                .WithMany(p => p.PiranhaPageRevisions)
                .HasForeignKey(d => d.PageId);
        }
    }
}