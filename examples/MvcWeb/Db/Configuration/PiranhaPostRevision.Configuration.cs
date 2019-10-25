using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp.Db.Configuration
{
    public class PiranhaPostRevisionConfiguration : IEntityTypeConfiguration<PiranhaPostRevision>
    {
        public void Configure(EntityTypeBuilder<PiranhaPostRevision> builder)
        {
            builder.ToTable("Piranha_PostRevisions");

            builder.HasIndex(e => e.PostId);

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.HasOne(d => d.Post)
                .WithMany(p => p.PiranhaPostRevisions)
                .HasForeignKey(d => d.PostId);
        }
    }
}