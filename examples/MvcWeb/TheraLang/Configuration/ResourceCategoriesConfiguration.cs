using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcWeb.Db.Entities;

namespace MvcWeb.Db.Configuration
{
    public class ResourceCategoriesConfiguration : IEntityTypeConfiguration<ResourceCategory>
    {
        public void Configure(EntityTypeBuilder<ResourceCategory> builder)
        {
            builder.ToTable("ResourceCategories");

            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).ValueGeneratedOnAdd();
            builder.Property(i => i.Type).HasMaxLength(20).IsRequired();
            
            // Relationship.
            builder.HasMany(c => c.Resources).WithOne(r => r.ResourceCategory).HasForeignKey(c => c.CategoryId);
        }
    }
}
