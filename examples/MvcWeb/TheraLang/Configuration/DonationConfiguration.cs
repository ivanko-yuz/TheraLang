using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcWeb.TheraLang.Entities;


namespace MvcWeb.TheraLang.Configuration
{
    public class DonationConfiguration : IEntityTypeConfiguration<Donation>
    {
        public void Configure(EntityTypeBuilder<Donation> builder)
        {
            builder.ToTable("Donations");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Status).HasMaxLength(250).IsRequired();
            builder.Property(e => e.Amount).HasMaxLength(250).IsRequired();
            builder.Property(e => e.ProjectId).IsRequired();
        }
    }
}
