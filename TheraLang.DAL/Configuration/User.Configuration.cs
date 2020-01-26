﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.DAL.Entities;

namespace TheraLang.DAL.Piranha.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasIndex(e => e.NormalizedEmail)
                .HasName("EmailIndex");

            builder.HasIndex(e => e.NormalizedUserName)
                .HasName("UserNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedUserName] IS NOT NULL)");

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.Email).HasMaxLength(256);

            builder.Property(e => e.NormalizedEmail).HasMaxLength(256);

            builder.Property(e => e.NormalizedUserName).HasMaxLength(256);

            builder.Property(e => e.UserName).HasMaxLength(256);

            builder.HasMany(x => x.Resources).WithOne(i => i.User).
                HasForeignKey(e => e.CreatedById).OnDelete(DeleteBehavior.Restrict);
          
        }
    }
}