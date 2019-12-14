using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.DLL.Entities;

namespace TheraLang.DLL.Configuration
{
    class ResourceAttachmentConfiguration : IEntityTypeConfiguration<ResourceAttachment>
    {
        public void Configure(EntityTypeBuilder<ResourceAttachment> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.FileName).HasMaxLength(250);

            builder.Property(e => e.Path).HasMaxLength(1000);

            builder.HasOne(e => e.Resource).WithMany(e => e.ResourceAttachment).HasForeignKey("ResourceId").OnDelete(deleteBehavior: 0);
        }
    }
}
