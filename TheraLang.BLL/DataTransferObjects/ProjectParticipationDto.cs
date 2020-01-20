using TheraLang.DAL.Piranha.Entities;

namespace TheraLang.BLL.DataTransferObjects
{
    public class ProjectParticipationDto
    {
        public PiranhaUser PiranhaUser { get; set; }

        public MemberRoleDto Role { get; set; }

        public ProjectParticipationStatusDto Status { get; set; }

        public int ProjectId { get; set; }

        public virtual ProjectDto Project { get; set; }
    }
}
