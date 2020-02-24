using Common.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheraLang.DAL.Entities;

namespace TheraLang.DAL.Configuration
{
    public class DonationConfiguration : IEntityTypeConfiguration<Donation>
    {
        public void Configure(EntityTypeBuilder<Donation> builder)
        {
            var actionConverter = new EnumToStringConverter<LiqPayAction>();
            var statusConverter = new EnumToStringConverter<LiqPayStatus>();
            var currencyConverter = new EnumToStringConverter<LiqPayCurrency>();

            builder.ToTable("Donations");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.ProjectId);
            builder.Property(p => p.SocietyId);
            builder.Property(p => p.Status)
                .IsRequired()
                .HasConversion(statusConverter)
                .HasMaxLength(16);
            builder.Property(p => p.Amount).IsRequired().HasColumnType("decimal(18, 2)");
            builder.Property(p => p.Currency)
                .IsRequired()
                .HasConversion(currencyConverter)
                .HasMaxLength(8);
            builder.Property(p => p.PaymentId).IsRequired();
            builder.Property(p => p.LiqpayOrderId).IsRequired().HasMaxLength(24);
            builder.Property(p => p.Action)
                .IsRequired()
                .HasConversion(actionConverter)
                .HasMaxLength(16);
            builder.Property(p => p.TimeStamp).HasDefaultValueSql("GETDATE()");
        }
    }
}