using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLangWeb.Db.Entities;

namespace TheraLangWeb.Db.Configuration
{
    public class PiranhaPageFieldConfiguration : IEntityTypeConfiguration<PiranhaPageField>
    {
        public void Configure(EntityTypeBuilder<PiranhaPageField> builder)
        {
            builder.ToTable("Piranha_PageFields");

            builder.HasIndex(e => new {e.PageId, e.RegionId, e.FieldId, e.SortOrder});

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.ClrType)
                .IsRequired()
                .HasColumnName("CLRType")
                .HasMaxLength(256);

            builder.Property(e => e.FieldId)
                .IsRequired()
                .HasMaxLength(64);

            builder.Property(e => e.RegionId)
                .IsRequired()
                .HasMaxLength(64);

            builder.HasOne(d => d.Page)
                .WithMany(p => p.PiranhaPageFields)
                .HasForeignKey(d => d.PageId);
        }
    }
}