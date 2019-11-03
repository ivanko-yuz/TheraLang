using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcWeb.Db.Entities;

namespace MvcWeb.Db.Configuration
{
    public class ResourceProjectConfiguration : IEntityTypeConfiguration<ResourceProject>
    {
        public void Configure(EntityTypeBuilder<ResourceProject> builder)
        {
            builder.ToTable("ResourceToProject");

            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).ValueGeneratedOnAdd();

            // Relationship...
            builder.HasOne(r => r.Resource).WithMany(p => p.ResourceProject);
            
            // Maybe can be Unique Object ?
            // builder.HasIndex(i => new { i.ProjectId, i.ResourceId }).IsUnique();
        }
    }
}
