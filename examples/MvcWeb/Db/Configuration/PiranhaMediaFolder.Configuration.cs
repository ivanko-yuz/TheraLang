using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcWeb.Db.Entities;

namespace MvcWeb.Db.Configuration
{
    public class PiranhaMediaFolderConfiguration : IEntityTypeConfiguration<PiranhaMediaFolder>
    {
        public void Configure(EntityTypeBuilder<PiranhaMediaFolder> builder)
        {
            builder.ToTable("Piranha_MediaFolders");

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(128);
        }
    }
}