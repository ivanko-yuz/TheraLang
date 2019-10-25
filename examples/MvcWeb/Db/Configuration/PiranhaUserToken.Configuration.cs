using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp.Db.Configuration
{
    public class PiranhaUserTokenConfiguration:IEntityTypeConfiguration<PiranhaUserToken>
    {
        public void Configure(EntityTypeBuilder<PiranhaUserToken> builder)
        {
            builder.HasKey(e => new {e.UserId, e.LoginProvider, e.Name});

            builder.ToTable("Piranha_UserTokens");

            builder.HasOne(d => d.User)
                .WithMany(p => p.PiranhaUserTokens)
                .HasForeignKey(d => d.UserId);
        }
    }
}