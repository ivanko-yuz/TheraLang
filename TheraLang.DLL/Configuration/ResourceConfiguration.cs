﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.DLL.Entities;

namespace TheraLang.DLL.Configuration
{
    public class ResourceConfiguration : BaseEntityConfiguration<Resource>
    {
        public override void Configure(EntityTypeBuilder<Resource> builder)
        {
            builder.ToTable("Resources");

            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
            builder.HasIndex(x => x.Name).IsUnique();
            builder.Property(x => x.Description).HasMaxLength(5000).IsRequired();
            builder.Property(x => x.CategoryId).IsRequired();
            builder.Property(x => x.Url).HasDefaultValue(null);
            builder.Property(x => x.FileName).HasDefaultValue(null);

            builder.HasMany(x => x.ResourceProjects).WithOne(i => i.Resource).
                HasForeignKey(e => e.ResourceId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
