using TheraLang.DAL.Entities;

namespace TheraLang.BLL.DataTransferObjects
{
    public class ProjectParticipationDto
    {
        public User User { get; set; }

        public MemberRoleDto Role { get; set; }

        public ProjectParticipationStatusDto Status { get; set; }

        public int ProjectId { get; set; }

        public virtual ProjectDto Project { get; set; }
    }
}
