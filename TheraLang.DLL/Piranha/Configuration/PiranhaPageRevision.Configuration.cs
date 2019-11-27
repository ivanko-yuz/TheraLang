using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.DLL.Piranha.Entities;

namespace TheraLang.DLL.Piranha.Configuration
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