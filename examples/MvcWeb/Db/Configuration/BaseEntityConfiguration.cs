using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcWeb.Db.Entities;

namespace MvcWeb.Db.Configuration
{
    public class BaseEntityConfiguration : IEntityTypeConfiguration<BaseEntity>
    {
        public void Configure(EntityTypeBuilder<BaseEntity> builder)
        {
            builder.Property(i => i.CreatedbyId).IsRequired();
            builder.Property(i => i.CreatedDateUTC).IsRequired();
        }
    }
}
