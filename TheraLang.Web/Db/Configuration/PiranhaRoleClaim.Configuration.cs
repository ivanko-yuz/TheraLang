using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.Web.Db.Entities;

namespace TheraLang.Web.Db.Configuration
{
    public class PiranhaRoleClaimConfiguration : IEntityTypeConfiguration<PiranhaRoleClaim>
    {
        public void Configure(EntityTypeBuilder<PiranhaRoleClaim> builder)
        {
            builder.ToTable("Piranha_RoleClaims");

            builder.HasIndex(e => e.RoleId);

            builder.HasOne(d => d.Role)
                .WithMany(p => p.PiranhaRoleClaims)
                .HasForeignKey(d => d.RoleId);
        }
    }
}