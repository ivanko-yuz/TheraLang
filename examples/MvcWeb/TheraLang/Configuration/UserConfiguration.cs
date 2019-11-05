using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcWeb.TheraLang.Entities;

namespace MvcWeb.TheraLang.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).ValueGeneratedOnAdd();

            builder.Property(i => i.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(i => i.LastName).HasMaxLength(50).IsRequired();
            builder.Property(i => i.Email).HasMaxLength(100).IsRequired();
            builder.Property(i => i.PhooneNumber).IsRequired();
            builder.Property(i => i.IsEmailConfirmed).IsRequired();
            builder.Property(i => i.IsPhoneNumberConfirmed).IsRequired();
            builder.Property(i => i.RegistrationDate).IsRequired();

            builder.HasMany(r => r.Resources).WithOne(i => i.User);
        }
    }
}
