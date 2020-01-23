using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.DAL.Piranha.Entities;

namespace TheraLang.DAL.Piranha.Configuration
{
    public class PiranhaBlockFieldConfiguration : IEntityTypeConfiguration<PiranhaBlockField>
    {
        public void Configure(EntityTypeBuilder<PiranhaBlockField> builder)
        {
            builder.ToTable("Piranha_BlockFields");

            builder.HasIndex(e => new {e.BlockId, e.FieldId, e.SortOrder})
                .IsUnique();

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.ClrType)
                .IsRequired()
                .HasColumnName("CLRType")
                .HasMaxLength(256);

            builder.Property(e => e.FieldId)
                .IsRequired()
                .HasMaxLength(64);

            builder.HasOne(d => d.Block)
                .WithMany(p => p.PiranhaBlockFields)
                .HasForeignKey(d => d.BlockId);
        }
    }
}