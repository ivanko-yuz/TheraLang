using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.DLL.Piranha.Entities;

namespace TheraLang.DLL.Piranha.Configuration
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