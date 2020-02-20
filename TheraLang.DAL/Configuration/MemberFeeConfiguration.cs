using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.DAL.Entities;

namespace TheraLang.DAL.Configuration
{
    internal class MemberFeeConfiguration : IEntityTypeConfiguration<MemberFee>
    {
        public void Configure(EntityTypeBuilder<MemberFee> builder)
        {
            builder.ToTable("MemberFees");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.FeeDate).IsRequired();

            builder.Property(e => e.CreatedById).IsRequired();

            builder.Property(x => x.FeeAmount).IsRequired().HasColumnType("decimal(18, 2)");
        }
    }
}