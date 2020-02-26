using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TheraLang.DAL.Entities;

namespace TheraLang.DAL.Configuration
{
    class PaymentHistoryConfiguration : IEntityTypeConfiguration<PaymentHistory>
    {
        public void Configure(EntityTypeBuilder<PaymentHistory> builder)
        {
            builder.ToTable("PaymentHistory");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Date).IsRequired();
            builder.Property(x => x.Description).IsRequired().HasMaxLength(32);
            builder.Property(x => x.Saldo).IsRequired();
            builder.HasOne(x => x.Payer).WithMany().HasForeignKey(x => x.UserId);
        }
    }
}
