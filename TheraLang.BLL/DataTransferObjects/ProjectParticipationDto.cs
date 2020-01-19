using System;
using System.Collections.Generic;
using System.Text;
using TheraLang.DAL.Entities;
using TheraLang.DAL.Enums;
using TheraLang.DAL.Piranha.Entities;

namespace TheraLang.BLL.DataTransferObjects
{
    public class ProjectParticipationDto
    {
        public virtual PiranhaUser PiranhaUser { get; set; }

        public MemberRoleDto Role { get; set; }

        public ProjectParticipationStatusDto Status { get; set; }

        public int ProjectId { get; set; }

        public virtual ProjectDto Project { get; set; }
    }
}
