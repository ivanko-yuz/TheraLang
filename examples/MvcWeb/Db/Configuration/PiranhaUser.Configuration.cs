using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcWeb.Db.Entities;

namespace MvcWeb.Db.Configuration
{
    public class PiranhaUserConfiguration : IEntityTypeConfiguration<PiranhaUser>
    {
        public void Configure(EntityTypeBuilder<PiranhaUser> builder)
        {
            builder.ToTable("Piranha_Users");

            builder.HasIndex(e => e.NormalizedEmail)
                .HasName("EmailIndex");

            builder.HasIndex(e => e.NormalizedUserName)
                .HasName("UserNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedUserName] IS NOT NULL)");

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.Email).HasMaxLength(256);

            builder.Property(e => e.NormalizedEmail).HasMaxLength(256);

            builder.Property(e => e.NormalizedUserName).HasMaxLength(256);

            builder.Property(e => e.UserName).HasMaxLength(256);

            builder.HasMany(i => i.Resources).WithOne(r => r.User).HasForeignKey("CreatedById");
        }
    }
}