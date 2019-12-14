using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.DLL.Entities;

namespace TheraLang.DLL.Configuration
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Projects");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.Name).HasMaxLength(250).IsRequired();

            builder.Property(e => e.Description).HasMaxLength(5000).IsRequired();

            builder.Property(e => e.ProjectStart).IsRequired();

            builder.Property(e => e.ProjectEnd).IsRequired();

            builder.Property(e => e.Details).HasMaxLength(5000);

            builder.Property(e => e.IsActive);

            builder.HasOne(e => e.Type).WithMany(p => p.Projects).
                HasForeignKey(d => d.TypeId).OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.ProjectResources).WithOne(i => i.Project).HasForeignKey("ProjectId");

            builder.HasMany(x => x.ProjectParticipations).WithOne(i => i.Project).HasForeignKey("ProjectId");

            builder.HasMany(e => e.Donations).WithOne(i => i.Project).HasForeignKey("ProjectId");

            builder.Property(e => e.StatusId).HasMaxLength(250).IsRequired().HasDefaultValue(Entities.ProjectStatus.New);

            builder.HasMany(x => x.ProjectParticipations).WithOne(i => i.Project)
                .HasForeignKey(e => e.ProjectId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}