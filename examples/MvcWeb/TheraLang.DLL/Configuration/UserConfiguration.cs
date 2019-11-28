using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLangWeb.TheraLang.DLL.Entities;

namespace TheraLangWeb.TheraLang.DLL.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(100).IsRequired();
            builder.Property(x => x.PhooneNumber).IsRequired();
            builder.Property(x => x.IsEmailConfirmed).IsRequired();
            builder.Property(x => x.IsPhoneNumberConfirmed).IsRequired();
            builder.Property(x => x.RegistrationDate).IsRequired();

            builder.HasMany(x => x.Resources).WithOne(i => i.User);
        }
    }
}
