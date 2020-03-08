using Common.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheraLang.DAL.Entities;

namespace TheraLang.DAL.Configuration
{
    class PaymentHistoryConfiguration : IEntityTypeConfiguration<PaymentHistory>
    {
        public void Configure(EntityTypeBuilder<PaymentHistory> builder)
        {
            var descriptionConverter = new EnumToStringConverter<PaymentDescription>();

            builder.ToTable("PaymentHistory");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Date).HasDefaultValueSql("GETDATE()");
            builder.Property(x => x.Description)
                .IsRequired()
                .HasConversion(descriptionConverter)
                .HasMaxLength(32);
            builder.Property(x => x.Saldo).IsRequired().HasColumnType("decimal(18, 2)");
            builder.Property(x => x.CurrentBalance).HasColumnType("decimal(18, 2)");

            builder.HasOne(x => x.Payer).WithMany().HasForeignKey(x => x.UserId);
        }
    }
}
