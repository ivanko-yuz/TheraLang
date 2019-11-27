using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.DLL.Piranha.Entities;

namespace TheraLang.DLL.Piranha.Configuration
{
    public class PiranhaSiteTypeConfiguration : IEntityTypeConfiguration<PiranhaSiteType>
    {
        public void Configure(EntityTypeBuilder<PiranhaSiteType> builder)
        {
            builder.ToTable("Piranha_SiteTypes");

            builder.Property(e => e.Id).HasMaxLength(64);

            builder.Property(e => e.ClrType)
                .HasColumnName("CLRType")
                .HasMaxLength(256);
        }
    }
}