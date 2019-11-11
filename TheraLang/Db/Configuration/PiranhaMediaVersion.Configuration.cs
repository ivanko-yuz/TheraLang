using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.Db.Entities;

namespace TheraLang.Db.Configuration
{
    public class PiranhaMediaVersionConfiguration : IEntityTypeConfiguration<PiranhaMediaVersion>
    {
        public void Configure(EntityTypeBuilder<PiranhaMediaVersion> builder)
        {
            builder.ToTable("Piranha_MediaVersions");

            builder.HasIndex(e => new {e.MediaId, e.Width, e.Height})
                .IsUnique();

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.FileExtension).HasMaxLength(8);

            builder.HasOne(d => d.Media)
                .WithMany(p => p.PiranhaMediaVersions)
                .HasForeignKey(d => d.MediaId);
        }
    }
}