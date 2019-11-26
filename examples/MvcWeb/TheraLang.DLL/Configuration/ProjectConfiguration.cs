﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcWeb.TheraLang.Entities;

namespace MvcWeb.TheraLang.Configuration
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Projects");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Type).HasMaxLength(250).IsRequired();

            builder.HasMany(x => x.ProjectResources).WithOne(i => i.Project).HasForeignKey("ProjectId");
            builder.HasMany(x => x.ProjectParticipations).WithOne(i => i.Project).HasForeignKey("ProjectId");
            builder.Property(e => e.Name).HasMaxLength(250).IsRequired();

            builder.Property(e => e.Type).HasMaxLength(250).IsRequired();

            builder.Property(e => e.StatusId).HasMaxLength(250).IsRequired().HasDefaultValue(Entities.ProjectStatus.New); 

        }
    }
}
