using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcWeb.TheraLang.Entities;

namespace MvcWeb.TheraLang.Configuration
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

            builder.HasOne(e => e.Type).WithMany(p => p.Projects).HasForeignKey(d => d.TypeId);
        }
    }
}