using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp.Db.Configuration
{
    public class PiranhaMediaConfiguration:IEntityTypeConfiguration<PiranhaMedia>
    {
        public void Configure(EntityTypeBuilder<PiranhaMedia> builder)
        {
            builder.ToTable("Piranha_Media");

            builder.HasIndex(e => e.FolderId);

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.ContentType)
                .IsRequired()
                .HasMaxLength(256);

            builder.Property(e => e.Filename)
                .IsRequired()
                .HasMaxLength(128);

            builder.HasOne(d => d.Folder)
                .WithMany(p => p.PiranhaMedia)
                .HasForeignKey(d => d.FolderId);
        }
    }
}