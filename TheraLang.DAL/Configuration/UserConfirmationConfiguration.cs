using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TheraLang.DAL.Entities;

namespace TheraLang.DAL.Configuration
{
        internal class UserConfirmationConfiguration : IEntityTypeConfiguration<UserConfirmation>
        {
            public void Configure(EntityTypeBuilder<UserConfirmation> builder)
            {
                builder.ToTable("UsersConfirmations");

            }
    }
}
