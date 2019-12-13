

using TheraLang.DLL.Enums;

namespace TheraLang.DLL.Entities
{
    public class ProjectParticipation : BaseEntity
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }
        
        public MemberRole Role { get; set; }

        public ProjectParticipationStatus Status { get; set; }

        public int ProjectId { get; set; }

        public virtual Project Project { get; set; }
    }
}
