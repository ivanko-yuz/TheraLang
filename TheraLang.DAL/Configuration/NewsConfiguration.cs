using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TheraLang.DAL.Entities;

namespace TheraLang.DAL.Configuration
{
    class NewsConfiguration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.ToTable("News");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Title).HasMaxLength(250).IsRequired();
            builder.Property(e => e.Text).IsRequired();
            builder.HasMany(e => e.UploadedImages).WithOne(i => i.News).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
