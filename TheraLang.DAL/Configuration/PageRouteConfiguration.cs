using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.DAL.Entities;

namespace TheraLang.DAL.Configuration
{
    public class PageRouteConfiguration : IEntityTypeConfiguration<PageRoute>
    {
        public void Configure(EntityTypeBuilder<PageRoute> builder)
        {
            builder.ToTable("PageRoutes");

            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Route).IsRequired().HasMaxLength(140); ;
            builder.HasIndex(p => p.Route).IsUnique();
            builder.HasMany(x => x.Pages)
                .WithOne(x => x.Route)
                .HasForeignKey(x => x.RouteId);
        }
    }
}
