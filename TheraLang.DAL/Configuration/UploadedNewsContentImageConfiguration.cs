using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.DAL.Entities;

namespace TheraLang.DAL.Configuration
{
    class UploadedNewsContentImageConfiguration : IEntityTypeConfiguration<UploadedNewsContentImage>
    {
        public void Configure(EntityTypeBuilder<UploadedNewsContentImage> builder)
        {
            builder.ToTable("UploadedNewsContentImages");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Url).IsRequired();
        }
    }
}
