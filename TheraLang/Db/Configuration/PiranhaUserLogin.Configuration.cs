using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.Db.Entities;

namespace TheraLang.Db.Configuration
{
    public class PiranhaUserLoginConfiguration : IEntityTypeConfiguration<PiranhaUserLogin>
    {
        public void Configure(EntityTypeBuilder<PiranhaUserLogin> builder)
        {
            builder.HasKey(e => new {e.LoginProvider, e.ProviderKey});

            builder.ToTable("Piranha_UserLogins");

            builder.HasIndex(e => e.UserId);

            builder.HasOne(d => d.User)
                .WithMany(p => p.PiranhaUserLogins)
                .HasForeignKey(d => d.UserId);
        }
    }
}