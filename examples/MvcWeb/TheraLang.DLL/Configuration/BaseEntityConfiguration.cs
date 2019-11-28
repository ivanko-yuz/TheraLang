using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLangWeb.TheraLang.DLL.Entities;

namespace TheraLangWeb.TheraLang.DLL.Configuration
{
    public abstract class BaseEntityConfiguration<TBase> : IEntityTypeConfiguration<TBase> where TBase : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TBase> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.CreatedById).IsRequired();
            builder.Property(x => x.CreatedDateUtc).IsRequired();
            builder.Property(x => x.UpdatedById).HasDefaultValue();
            builder.Property(x => x.UpdatedDateUtc).HasDefaultValue();
        }
    }
}
