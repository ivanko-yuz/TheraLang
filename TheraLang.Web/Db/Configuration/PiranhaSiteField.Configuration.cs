using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.Web.Db.Entities;

namespace TheraLang.Web.Db.Configuration
{
    public class PiranhaSiteFieldConfiguration : IEntityTypeConfiguration<PiranhaSiteField>
    {
        public void Configure(EntityTypeBuilder<PiranhaSiteField> builder)
        {
            builder.ToTable("Piranha_SiteFields");

            builder.HasIndex(e => new {e.SiteId, e.RegionId, e.FieldId, e.SortOrder});

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

            builder.HasOne(d => d.Site)
                .WithMany(p => p.PiranhaSiteFields)
                .HasForeignKey(d => d.SiteId);
        }
    }
}