using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.DAL.Entities;

namespace TheraLang.DAL.Configuration
{
    internal class UserDetailsConfiguration : IEntityTypeConfiguration<UserDetails>
    {
        public void Configure(EntityTypeBuilder<UserDetails> builder)
        {
            builder.ToTable("UsersDetails");
            builder.Property(e => e.FirstName).HasMaxLength(32);
            builder.Property(e => e.LastName).HasMaxLength(32);
            builder.Property(e => e.Balance).HasDefaultValue(0);
        }
    }
}