using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.DAL.Entities;

namespace TheraLang.DAL.Configuration
{
    public class PageRouteConfiguration : IEntityTypeConfiguration<PageRoute>
    {
        public void Configure(EntityTypeBuilder<PageRoute> builder)
        {
            builder.ToTable("PageRoutes");

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Route).IsRequired().HasMaxLength(140);
            builder.HasIndex(p => p.Route).IsUnique();
            builder.HasMany(x => x.Pages)
                .WithOne(x => x.PageRoute)
                .HasForeignKey(x => x.RouteId);
        }
    }
}