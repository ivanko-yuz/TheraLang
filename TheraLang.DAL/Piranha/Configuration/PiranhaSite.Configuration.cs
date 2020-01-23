using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.DAL.Piranha.Entities;

namespace TheraLang.DAL.Piranha.Configuration
{
    public class PiranhaSiteConfiguration : IEntityTypeConfiguration<PiranhaSite>
    {
        public void Configure(EntityTypeBuilder<PiranhaSite> builder)
        {
            builder.ToTable("Piranha_Sites");

            builder.HasIndex(e => e.InternalId)
                .IsUnique();

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.Culture).HasMaxLength(6);

            builder.Property(e => e.Description).HasMaxLength(256);

            builder.Property(e => e.Hostnames).HasMaxLength(256);

            builder.Property(e => e.InternalId)
                .IsRequired()
                .HasMaxLength(64);

            builder.Property(e => e.SiteTypeId).HasMaxLength(64);

            builder.Property(e => e.Title).HasMaxLength(128);
        }
    }
}