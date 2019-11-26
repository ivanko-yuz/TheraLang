using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.Web.Db.Entities;

namespace TheraLang.Web.Db.Configuration
{
    public class PiranhaPageBlockConfiguration : IEntityTypeConfiguration<PiranhaPageBlock>
    {
        public void Configure(EntityTypeBuilder<PiranhaPageBlock> builder)
        {
            builder.ToTable("Piranha_PageBlocks");

            builder.HasIndex(e => e.BlockId);

            builder.HasIndex(e => new {e.PageId, e.SortOrder})
                .IsUnique();

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.HasOne(d => d.Block)
                .WithMany(p => p.PiranhaPageBlocks)
                .HasForeignKey(d => d.BlockId);

            builder.HasOne(d => d.Page)
                .WithMany(p => p.PiranhaPageBlocks)
                .HasForeignKey(d => d.PageId);
        }
    }
}