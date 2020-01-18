using TheraLang.DAL.Enums;
using TheraLang.DAL.Piranha.Entities;

namespace TheraLang.DAL.Entities
{
    public class ProjectParticipation : BaseEntity
    {
        public virtual PiranhaUser PiranhaUser { get; set; }

        public MemberRole Role { get; set; }

        public ProjectParticipationStatus Status { get; set; }

        public int ProjectId { get; set; }

        public virtual Project Project { get; set; }
    }
}
