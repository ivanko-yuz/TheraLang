using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcWeb.Db.Entities;

namespace MvcWeb.Db.Configuration
{
    public class PiranhaRoleConfiguration : IEntityTypeConfiguration<PiranhaRole>
    {
        public void Configure(EntityTypeBuilder<PiranhaRole> builder)
        {
            builder.ToTable("Piranha_Roles");

            builder.HasIndex(e => e.NormalizedName)
                .HasName("RoleNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedName] IS NOT NULL)");

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.Name).HasMaxLength(256);

            builder.Property(e => e.NormalizedName).HasMaxLength(256);
        }
    }
}