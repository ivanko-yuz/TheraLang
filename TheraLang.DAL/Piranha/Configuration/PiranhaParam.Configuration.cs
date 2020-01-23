using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.DAL.Piranha.Entities;

namespace TheraLang.DAL.Piranha.Configuration
{
    public class PiranhaParamConfiguration : IEntityTypeConfiguration<PiranhaParam>
    {
        public void Configure(EntityTypeBuilder<PiranhaParam> builder)
        {
            builder.ToTable("Piranha_Params");

            builder.HasIndex(e => e.Key)
                .IsUnique();

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.Description).HasMaxLength(256);

            builder.Property(e => e.Key)
                .IsRequired()
                .HasMaxLength(64);
        }
    }
}