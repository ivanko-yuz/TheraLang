using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.DAL.Entities;

namespace TheraLang.DAL.Configuration
{
    public class DonationConfiguration : IEntityTypeConfiguration<Donation>
    {
        public void Configure(EntityTypeBuilder<Donation> builder)
        {
            builder.ToTable("Donations");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.ProjectId);
            builder.Property(p => p.SocietyId).HasDefaultValue(null);
            builder.Property(p => p.Status).IsRequired();
            builder.Property(p => p.Amount).IsRequired().HasColumnType("decimal(18, 2)");
            builder.Property(p => p.Currency).IsRequired();
            builder.Property(p => p.PaymentId).IsRequired();
            builder.Property(p => p.LiqpayOrderId).IsRequired();
        }
    }
}
