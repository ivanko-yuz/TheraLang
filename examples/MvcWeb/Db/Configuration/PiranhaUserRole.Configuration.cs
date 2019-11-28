using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLangWeb.Db.Entities;

namespace TheraLangWeb.Db.Configuration
{
    public class PiranhaUserRoleConfiguration : IEntityTypeConfiguration<PiranhaUserRole>
    {
        public void Configure(EntityTypeBuilder<PiranhaUserRole> builder)
        {
            builder.HasKey(e => new {e.UserId, e.RoleId});

            builder.ToTable("Piranha_UserRoles");

            builder.HasIndex(e => e.RoleId);

            builder.HasOne(d => d.Role)
                .WithMany(p => p.PiranhaUserRoles)
                .HasForeignKey(d => d.RoleId);

            builder.HasOne(d => d.User)
                .WithMany(p => p.PiranhaUserRoles)
                .HasForeignKey(d => d.UserId);
        }
    }
}