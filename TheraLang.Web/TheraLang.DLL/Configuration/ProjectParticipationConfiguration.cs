using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheraLang.Web.TheraLang.DLL.Entities;
using TheraLang.Web.TheraLang.DLL.Statuses;

namespace TheraLang.Web.TheraLang.DLL.Configuration
{
    public class ProjectParticipationConfiguration : BaseEntityConfiguration<ProjectParticipation>
    {
        public override void Configure(EntityTypeBuilder<ProjectParticipation> builder)
        {
            builder.ToTable("ProjectParticipations");

            builder.Property(x => x.Status).HasDefaultValue(ProjectParticipationStatus.New);
            builder.Property(x => x.Role).HasDefaultValue(MemberRole.Member);
            builder.Property(x => x.ProjectId).IsRequired();
        }
    }
}
