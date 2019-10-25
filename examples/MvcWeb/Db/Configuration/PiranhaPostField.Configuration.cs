using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp.Db.Configuration
{
    public class PiranhaPostFieldConfiguration:IEntityTypeConfiguration<PiranhaPostField>
    {
        public void Configure(EntityTypeBuilder<PiranhaPostField> builder)
        {
            builder.ToTable("Piranha_PostFields");

            builder.HasIndex(e => new {e.PostId, e.RegionId, e.FieldId, e.SortOrder});

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

            builder.HasOne(d => d.Post)
                .WithMany(p => p.PiranhaPostFields)
                .HasForeignKey(d => d.PostId);
        }
    }
}