using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcWeb.TheraLang.Entities;
using System;

namespace MvcWeb.TheraLang.Configuration
{
    public class TypeConfiguration : IEntityTypeConfiguration<TypeProject>
    {
        public void Configure(EntityTypeBuilder<TypeProject> builder)
        {
            builder.ToTable("Project_Types");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.TypeName).HasMaxLength(500);          
        }
    }
}
