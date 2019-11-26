using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcWeb.Db.Entities;

namespace MvcWeb.Db.Configuration
{
    public class PiranhaPostTypeConfiguration : IEntityTypeConfiguration<PiranhaPostType>
    {
        public void Configure(EntityTypeBuilder<PiranhaPostType> builder)
        {
            builder.ToTable("Piranha_PostTypes");

            builder.Property(e => e.Id).HasMaxLength(64);

            builder.Property(e => e.ClrType)
                .HasColumnName("CLRType")
                .HasMaxLength(256);
        }
    }
}