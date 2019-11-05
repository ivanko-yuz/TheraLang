using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcWeb.TheraLang.Entities;

namespace MvcWeb.TheraLang.Configuration
{
    public abstract class BaseEntityConfiguration<TBase> : IEntityTypeConfiguration<TBase> where TBase : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TBase> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).ValueGeneratedOnAdd();

            builder.Property(i => i.CreatedById).IsRequired();
            builder.Property(i => i.CreatedDateUtc).IsRequired();
            builder.Property(i => i.UpdatedById).HasDefaultValue();
            builder.Property(i => i.UpdatedById).HasDefaultValue();
        }
    }
}
