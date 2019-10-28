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

            // Relationship...
            builder.HasOne(r => r.Resource).WithOne(i => i.ResourceProject);

            // At table project must be navigation property to Resource project table.
            // builder.HasOne(p=>p.Project).WithOne(i=>i.ResourceProject);
        }
    }
}
