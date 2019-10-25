using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp.Db.Configuration
{
    public class PiranhaPostBlockConfiguration : IEntityTypeConfiguration<PiranhaPostBlock>
    {
        public void Configure(EntityTypeBuilder<PiranhaPostBlock> builder)
        {
            builder.ToTable("Piranha_PostBlocks");

            builder.HasIndex(e => e.BlockId);

            builder.HasIndex(e => new {e.PostId, e.SortOrder})
                .IsUnique();

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.HasOne(d => d.Block)
                .WithMany(p => p.PiranhaPostBlocks)
                .HasForeignKey(d => d.BlockId);

            builder.HasOne(d => d.Post)
                .WithMany(p => p.PiranhaPostBlocks)
                .HasForeignKey(d => d.PostId);
        }
    }
}