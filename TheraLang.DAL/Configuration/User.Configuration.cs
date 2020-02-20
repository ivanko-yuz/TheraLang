using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.DAL.Entities;

namespace TheraLang.DAL.Piranha.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Email).HasMaxLength(256);
            builder.HasMany(x => x.Resources).WithOne(i => i.User).HasForeignKey(e => e.CreatedById)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasIndex(x => x.Email).IsUnique();
            builder.HasOne(d => d.Details).WithOne(u => u.User).HasForeignKey<UserDetails>(x => x.UserDetailsId);
        }
    }
}