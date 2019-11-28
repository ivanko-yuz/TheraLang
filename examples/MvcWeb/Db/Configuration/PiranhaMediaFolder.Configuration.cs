using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLangWeb.Db.Entities;

namespace TheraLangWeb.Db.Configuration
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