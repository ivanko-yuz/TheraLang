﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.DAL.Piranha.Entities;

namespace TheraLang.DAL.Piranha.Configuration
{
    public class PiranhaUserClaimConfiguration : IEntityTypeConfiguration<PiranhaUserClaim>
    {
        public void Configure(EntityTypeBuilder<PiranhaUserClaim> builder)
        {
            builder.ToTable("Piranha_UserClaims");

            builder.HasIndex(e => e.UserId);

            builder.HasOne(d => d.User)
                .WithMany(p => p.PiranhaUserClaims)
                .HasForeignKey(d => d.UserId);
        }
    }
}