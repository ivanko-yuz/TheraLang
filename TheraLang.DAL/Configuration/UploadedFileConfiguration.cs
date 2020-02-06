using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TheraLang.DAL.Entities;

namespace TheraLang.DAL.Configuration
{
    class UploadedFileConfiguration : IEntityTypeConfiguration<UploadedNewsImage>
    {
        public void Configure(EntityTypeBuilder<UploadedNewsImage> builder)
        {
            builder.ToTable("UploadedNewsImages");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Url).IsRequired();
        }
    }
}
